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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            User user = BookClub.GetContext().Users.Where(p=> p.UserLogin.ToString() == TxtLogin.Text && p.UserPassword.ToString() == TxtPassword.Password.ToString()).FirstOrDefault();
            if (user != null)
            {
                FrameManager.frame.Navigate(new BookPage(user));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void BtnAuthGuest_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.frame.Navigate(new BookPage(null));
        }
    }
}
