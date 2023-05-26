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
    /// Логика взаимодействия для EditBookPage.xaml
    /// </summary>
    public partial class EditBookPage : Page
    {
        Book EditBook;
        public EditBookPage(Book book)
        {
            InitializeComponent();
            EditBook = book;
            TxtNameOfBook.Text = book.NameOfBook.ToString();
            TxtCostOfBook.Text = book.CostOfBook.ToString();
            TxtAuthorOfBook.Text = book.AuthorOfBook.ToString();
        }

        private void EditBookInfo_Click(object sender, RoutedEventArgs e)
        {
            Book book = BookClub.GetContext().Books.Find(EditBook.IDBook);
            book.NameOfBook = TxtNameOfBook.Text;
            book.CostOfBook = Convert.ToDecimal(TxtCostOfBook.Text);
            book.AuthorOfBook = TxtAuthorOfBook.Text;
            BookClub.GetContext().SaveChanges();
            FrameManager.frame.GoBack();
        }
    }
}
