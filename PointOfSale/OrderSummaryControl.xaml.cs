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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Removes the item from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                    
                }

            }
        }

        /// <summary>
        /// A proxy event listener that passes on SelectionChanged events
        /// </summary>
        /// <param name="sender">The ListBox that had its selection changed</param>
        /// <param name="e">The event arguments</param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement screen = null;
            IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;
            var orderControl = this.FindAncestor<OrderControl>();

            if (item != null)
            {
                screen = (FrameworkElement)item.Screen;

            }
            else
            {
                screen = new MenuItemSelectionControl();
            }

            orderControl?.SwapScreen(screen);
        }
    }
}
