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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order order;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public CustomizeWater(object dc)
        {
            order = (Order)dc;
            InitializeComponent();
        }

        /// <summary>
        /// Filters which control was pressed and changes the holding state of the respective item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Water w = (Water)DataContext;
            switch (((Button)sender).Name)
            {
                case "SmallButton":
                    order.subtotalFunc(w, Size.Small);
                    break;
                case "MediumButton":
                    order.subtotalFunc(w, Size.Medium);
                    break;
                case "LargeButton":
                    order.subtotalFunc(w, Size.Large);
                    break;
                default:
                    throw new NotImplementedException("Unknown Water Toggle Button Pressed");
            }
            order.InvokePropertyChanged();
        }
    }
}
