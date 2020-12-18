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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// private int id;
    public partial class MainWindow : Window
    {
        Book[] book = new Book[3];
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i <= 2; i++)
            {
                book[i] = new Book();
            }
            book[0].authors = "Stephen Hawking";
            book[1].authors = "Robert Winston";
            book[2].authors = "Fedor Dostoevsky";

            book[0].name = "The Grand Design";
            book[1].name = "SuperHuman Encyclopedia";
            book[2].name = "Crime and Punishment";

            book[0].publisher = "Transworld Digital";
            book[1].publisher = "Dorling Kindersley";
            book[2].publisher = "Russian Bulletin";

            book[0].year = 2005;
            book[1].year = 1998;
            book[2].year = 1866;

            book[0].pages = 250;
            book[1].pages = 400;
            book[2].pages = 600;

            book[0].price = 450;
            book[1].price = 550;
            book[2].price = 900;

            book[0].bindingType = "Hard";
            book[1].bindingType = "Hard";
            book[2].bindingType = "Hard";
        }

        public void ListBox_Clear()
        {
            listBoxBook.Items.Clear();
        }
        private void btnBookAuthor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 2; i++)
                {
                    if (book[i].authors == Convert.ToString(txtBookAuthor.Text))
                    {
                        listBoxBook.Items.Add (book[i].authors + "' '" + book[i].name + "' '" + book[i].publisher + "' '" + book[i].pages + "' '" + book[i].price + "' '" + book[i].year + "' '" + book[i].bindingType);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void btnBookPublisher_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 2; i++)
                {
                    if (book[i].publisher == Convert.ToString(txtBookPublisher.Text))
                    {
                        listBoxBook.Items.Add(book[i].authors + "' '" + book[i].name + "' '" + book[i].publisher + "' '" + book[i].pages + "' '" + book[i].price + "' '" + book[i].year + "' '" + book[i].bindingType);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void btnBookYear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListBox_Clear();
                for (int i = 0; i <= 2; i++)
                {
                    if (book[i].year == Convert.ToInt32(txtBookYear.Text))
                    {
                        listBoxBook.Items.Add(book[i].authors + "' '" + book[i].name + "' '" + book[i].publisher + "' '" + book[i].pages + "' '" + book[i].price + "' '" + book[i].year + "' '" + book[i].bindingType);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "Ошибка", MessageBoxButton.OK);
            }
        }
    }
}
