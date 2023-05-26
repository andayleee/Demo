using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        public BookPage(User user)
        {
            InitializeComponent();
            RefreshList();
        }

        public void RefreshList()
        {
            LstBook.ItemsSource = BookClub.GetContext().Books.ToList();
        }

        private void LstBook_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.frame.Navigate(new AddBookPage());
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.frame.Navigate(new EditBookPage((Book)LstBook.SelectedItem));
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            Book book = (Book)LstBook.SelectedItem;
            if (book != null)
            {
                BookClub.GetContext().Books.Remove(book);
                BookClub.GetContext().SaveChanges();
                RefreshList();
            }
        }
    }
}
