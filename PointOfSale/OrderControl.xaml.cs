using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            Order.Items.Add("Texas Triple Burger");
        }
    }
}
