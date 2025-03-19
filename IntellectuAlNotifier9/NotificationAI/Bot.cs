using Azure;
using Azure.AI.Inference;
using Microsoft.Extensions.AI;

using Models;
using Newtonsoft.Json;

public class Bot
{
    // Переменные для доступа к моделям GitHub
    readonly private AzureKeyCredential _credential;
    readonly private string _modelName;

    readonly private Uri _modelEndpoint;
    readonly private IChatClient _chatClient;

    // Конструктор
    public Bot(string token, string modelName)
    {
        _credential = new(token);
        _modelName = modelName;

        // Этот адрес не изменяется
        _modelEndpoint = new Uri("https://models.inference.ai.azure.com");

        _chatClient = new ChatCompletionsClient(_modelEndpoint, _credential)
            .AsChatClient(_modelName);
    }

    // Отправка запроса к нейросети и получение на выходе модели напоминания
    public async Task<Notification> SendRequest(string request)
    {
        string prompt =
            $"Система: Твоя задача - преобразовывать сообщение пользователя в json-объект:\r" +
            $"\nclass Notification\r\n{{\r\n\tDateTime dateTime;\r\n\tstring title;\r\n\tstring message;\r\n\tint occurancy;\r\n}}, " +
            $"где dateTime - время и дата напоминания, title - короткое название напоминания, отражающее его смысл, message - само напоминание. " +
            $"Каждое сообщение будет содержать информацию о том, какое напоминание и когда нужно сделать. " +
            $"В параметр occurancy записывай значение от 0 до 100, говорящее о том, насколько ты уверен в соответствии сообщения объекту. " +
            $"Значение occurancy меньше 50 будет означать, что из сообщения пользователя не понятны время и напоминание." +
            $"Также в случае некорректного запроса можешь устанавливать dateTime, title и message в какие-либо минимальные значения кроме null " +
            $"В ответ пришли только содержимое конечного json-объекта без какого-либо форматирования.\r\n[Текущее время: {DateTime.Now.ToString()}] " +
            $"Пользователь: {request}";

        Notification? notification = null;

        // Получение ответа от нейросети
        IAsyncEnumerable<StreamingChatCompletionUpdate> response = _chatClient.CompleteStreamingAsync(prompt);

        if (response == null)
        {
            throw new NullReferenceException("Переменная response приняла значение null, ответ от нейросети получить не удалось");
        }

        string collectedResponse = await CollectResponse(response);

        // Десериализация в модель напоминания
        try
        {
            notification = Newtonsoft.Json.JsonConvert.DeserializeObject<Notification>(collectedResponse);
        }
        catch (JsonSerializationException e)
        {
            Console.WriteLine(e.Message);
        }

        if (notification != null)
        {
            return notification;
        }

        return new Notification();
    }

    // Собирает с ответом нейросети из вида
    // "Microsoft.Extensions.AI.AzureAIInferenceChatClient+<CompleteStreamingAsync>d__12"
    // в вид { json-чик }
    private async Task<string> CollectResponse(IAsyncEnumerable<StreamingChatCompletionUpdate> response)
    {
        string collectedResponse = "";

        await foreach (var item in response)
        {
            collectedResponse += item;
        }

        return collectedResponse;
    }
}
