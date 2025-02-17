using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntellectuAlNotifierDesktop
{
    /// <summary>
    /// Логика взаимодействия для SidePanel.xaml
    /// </summary>
    public partial class SidePanel : UserControl
    {
        public SidePanel()
        {
            InitializeComponent();
        }

        bool IsMenuVisible = true;
        private void btn_HideMenu_Click(object sender, RoutedEventArgs e)
        {
            brdr_SideMenu.BeginAnimation(MarginProperty, new ThicknessAnimation(new Thickness(IsMenuVisible ? -175 : 60, 0, 0, 0), TimeSpan.FromSeconds(0.1)));
            btn_HideMenu.Content = this.Resources[IsMenuVisible ? "btn_HideMenu_ContentShow" : "btn_HideMenu_ContentHide"];
            IsMenuVisible = !IsMenuVisible;
        }

        private void btn_NewNote_Click(object sender, RoutedEventArgs e)
        {
            tbk_PageHeader.Text = Resources["tbk_PageHeader_NewNote"].ToString();
            if (IsMenuVisible) btn_HideMenu.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void btn_Calendar_Click(object sender, RoutedEventArgs e)
        {
            tbk_PageHeader.Text = Resources["tbk_PageHeader_Calendar"].ToString();
            if (!IsMenuVisible) btn_HideMenu.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void btn_AllNotes_Click(object sender, RoutedEventArgs e)
        {
            tbk_PageHeader.Text = Resources["tbk_PageHeader_AllNotes"].ToString();
            if (!IsMenuVisible) btn_HideMenu.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private void btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            tbk_PageHeader.Text = Resources["tbk_PageHeader_Settings"].ToString();
            if (!IsMenuVisible) btn_HideMenu.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }
    }
}
