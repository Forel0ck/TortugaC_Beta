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
using TortugaC_Panchenko_Sheremetiev.Windows;

namespace TortugaC_Panchenko_Sheremetiev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Сергей Панченко", "Создатель", MessageBoxButton.OK, MessageBoxImage.None);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.ShowDialog();
            this.Close();

        }
        private void tbTable_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
        

    }
}
