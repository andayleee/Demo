using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DemoExam8800
{
    /// <summary>
    /// Логика взаимодействия для FrameWindow.xaml
    /// </summary>
    public partial class FrameWindow : Window
    {
        public FrameWindow()
        {
            InitializeComponent();
            FrameManager.frame = MainFrame;
            FrameManager.frame.Navigate(new AuthorizationPage());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (((Page)MainFrame.Content).Title.ToString() == "AuthorizationPage")
            {
                LbTitle.Content = "Авторизация";
                BtnBack.Visibility = Visibility.Hidden;
            }
            if (((Page)MainFrame.Content).Title.ToString() == "BookPage")
            {
                LbTitle.Content = "Книги";
                BtnBack.Visibility = Visibility.Visible;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}
