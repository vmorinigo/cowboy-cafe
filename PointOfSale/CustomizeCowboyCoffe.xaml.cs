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
    /// Interaction logic for CustomizeCowboyCoffe.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffe : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order order;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public CustomizeCowboyCoffe(object dc)
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
            CowboyCoffee cc = (CowboyCoffee)DataContext;
            switch (((Button)sender).Name)
            {
                case "SmallButton":
                    order.subtotalFunc(cc, Size.Small); break;
                case "MediumButton":
                    order.subtotalFunc(cc, Size.Medium); break;
                case "LargeButton":
                    order.subtotalFunc(cc, Size.Large); break;
                default:
                    throw new NotImplementedException("Unknown Cowboy Coffee Toggle Button Pressed");
            }
            order.InvokePropertyChanged();
        }
    }
}
