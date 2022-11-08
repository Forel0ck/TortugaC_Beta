using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using TortugaC_Panchenko_Sheremetiev.Classes;
using TortugaC_Panchenko_Sheremetiev.Pages;

namespace TortugaC_Panchenko_Sheremetiev.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    /// 
 
    public partial class MenuWindow : Window, INotifyPropertyChanged, MenuInterface
    {
        public MenuWindow()
        {
            InitializeComponent();
            tbQty.Text = "Ваши заказы: " + Basket.dishes.Count.ToString();
            Menu.Content = new Salads(this);
            
        }

        private void btnSalad_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Salads(this);
        }

        private void btnSoup_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Soup(this);
        }

        private void btnHotDishies_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new HotDishies(this);
        }

        private void btnGarnish_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Garnish(this);
        }

        private void btnDessert_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Dessert(this);
        }

        private void btnDrinks_Click(object sender, RoutedEventArgs e)
        {
            Menu.Content = new Drinks(this);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Orders orders = new Orders();
            orders.ShowDialog();
            this.Close();
        }

        private int countDishes;
                
        public int COuntDishes
        {
            get { return countDishes; }
            set { countDishes = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void ChangeDishCount(int count)
        {
            tbQty.Text = "Ваши заказы: " + count.ToString();
        }
    }
}
