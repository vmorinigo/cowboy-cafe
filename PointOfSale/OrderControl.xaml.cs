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
using CowboyCafe.Data;
using CowboyCafe.Extensions;
using Size = CowboyCafe.Data.Size;
using SodaFlavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            var order = new Order(1);
            DataContext = order;
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the Cancel Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Order o = (Order)DataContext;
            DataContext = new Order(o.OrderNumber + 1);
        }
        /// <summary>
        /// Event handler for the Complete Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Complete_Click(object sender, RoutedEventArgs e)
        {
            Order o = (Order)DataContext;
            DataContext = new Order(o.OrderNumber + 1);
        }

        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;

        }


    }
}
