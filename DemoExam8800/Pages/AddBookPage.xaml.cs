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
    /// Логика взаимодействия для AddBookPage.xaml
    /// </summary>
    public partial class AddBookPage : Page
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        private void AddBookInfo_Click(object sender, RoutedEventArgs e)
        {
            Book book = new Book();
            book.NameOfBook = TxtNameOfBook.Text;
            book.CostOfBook = Convert.ToDecimal(TxtCostOfBook.Text);
            book.AuthorOfBook = TxtAuthorOfBook.Text;
            BookClub.GetContext().Books.Add(book);
            BookClub.GetContext().SaveChanges();
            FrameManager.frame.GoBack();
        }
    }
}
