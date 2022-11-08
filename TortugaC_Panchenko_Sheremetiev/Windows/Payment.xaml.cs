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
using System.Windows.Shapes;

namespace TortugaC_Panchenko_Sheremetiev.Windows
{
    /// <summary>
    /// Логика взаимодействия для Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Close();
        }

        private void btnCash_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ обработан","Успешно",MessageBoxButton.OK,MessageBoxImage.Asterisk);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void btnCard_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ обработан", "Успешно", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }
    }
}
