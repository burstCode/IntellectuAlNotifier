using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntellectuAlNotifierDesktop
{
	/// <summary>
	/// Логика взаимодействия для NotificationPanel.xaml
	/// </summary>
	public partial class NotificationPanel : UserControl
	{
		public NotificationPanel()
		{
			InitializeComponent();
		}

		private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
		{
			(App.Current.MainWindow as Window).WindowState = WindowState.Minimized;
		}

		private void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e)
		{
			if ((App.Current.MainWindow as Window).WindowState == WindowState.Maximized)
			{
				(App.Current.MainWindow as Window).WindowState = WindowState.Normal;
			}
			else
			{
				(App.Current.MainWindow as Window).WindowState = WindowState.Maximized;
			}
			RefreshMaximizeRestoreButton();
		}

		private void OnCloseButtonClick(object sender, RoutedEventArgs e)
		{
			(App.Current.MainWindow as Window).Close();
		}

		private void RefreshMaximizeRestoreButton()
		{
			if ((App.Current.MainWindow as Window).WindowState == WindowState.Maximized)
			{
				this.maximizeButton.Visibility = Visibility.Collapsed;
				this.restoreButton.Visibility = Visibility.Visible;
			}
			else
			{
				this.maximizeButton.Visibility = Visibility.Visible;
				this.restoreButton.Visibility = Visibility.Collapsed;
			}
		}

		private void Window_StateChanged(object sender, EventArgs e)
		{
			this.RefreshMaximizeRestoreButton();
		}
	}
}
