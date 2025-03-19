namespace Models
{
    // Модель напоминания
    public class Notification
    {
        public DateTime dateTime { get; set; }
        public string? title { get; set; }
        public string? message { get; set; }
        public int occurancy { get; set; }

        // Конструктор без параметров
        public Notification()
        {
            dateTime = DateTime.MinValue;
            title = string.Empty;
            message = string.Empty;
            occurancy = 0;
        }

        // Конструктор с параметрами
        public Notification(DateTime dateTime, string? title, string? message, int occurancy)
        {
            this.dateTime = dateTime;
            this.title = title;
            this.message = message;
            this.occurancy = occurancy;
        }

        public override string ToString()
        {
            return
                $"{{" +
                $"\n\t{dateTime}," +
                $"\n\t{title}," +
                $"\n\t{message}," +
                $"\n\t{occurancy}" +
                $"\n}}";
        }
    }
}
