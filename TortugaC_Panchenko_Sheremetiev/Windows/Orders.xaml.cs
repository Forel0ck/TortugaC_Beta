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
using TortugaC_Panchenko_Sheremetiev.Classes;
using TortugaC_Panchenko_Sheremetiev.BD;
using static TortugaC_Panchenko_Sheremetiev.Classes.ClassEntities;
using static TortugaC_Panchenko_Sheremetiev.Classes.Basket;

namespace TortugaC_Panchenko_Sheremetiev.Windows
{
    /// <summary>
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
            lvOrder.ItemsSource = Basket.dishes.ToList();
            SummCost();
        }

        public void  SummCost()
        {
            double summ = 0;

            foreach (var item in dishes)
            {
                summ += Convert.ToDouble(item.Cost * item.Qty);
            }

            var res = summ;

            tbCost.Text = res.ToString() + '₽';
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.ShowDialog();
            this.Close();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.ShowDialog();
            this.Close();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (lvOrder.SelectedItem is Dish dish)
            {
                dish.Qty++;
                return;
            }
            else
            {
                MessageBox.Show($"Вы не выбрали блюдо", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {


            if (lvOrder.SelectedItem is Dish dish)
            {

                if (dish.Qty==1)
                {
                    var resMass = MessageBox.Show($"Вы точно хотите убрать блюдо {dish.Title} ?", "Предупреждение", MessageBoxButton.YesNo);
                    if (resMass == MessageBoxResult.Yes)
                    {
                        dishes.Remove(dishes.Where(i => i.IdDish == dish.IdDish).FirstOrDefault());
                        lvOrder.ItemsSource = dishes.ToList();

                        double summ = 0;
                        foreach (var item in dishes)
                        {
                            summ += Convert.ToDouble(item.Cost.ToString());
                        }
                        tbCost.Text = summ.ToString() + '₽';
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    dish.Qty--;
                    return;
                }

               
            }
            else
            {
                MessageBox.Show($"Вы не выбрали блюдо", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lvOrder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete || e.Key == Key.Back)
            {
                if (lvOrder.SelectedItem is Dish dish)
                {
                    var resMass = MessageBox.Show($"Вы точно хотите убрать блюдо {dish.Title} ?", "Предупреждение", MessageBoxButton.YesNo);
                    if (resMass == MessageBoxResult.Yes)
                    {
                        dishes.Remove(dishes.Where(i => i.IdDish == dish.IdDish).FirstOrDefault());
                        lvOrder.ItemsSource = dishes.ToList();

                        double summ = 0;
                        foreach (var item in dishes)
                        {
                            summ += Convert.ToDouble(item.Cost.ToString());
                        }
                        tbCost.Text = summ.ToString() + '₽';
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Вы не выбрали блюдо", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
