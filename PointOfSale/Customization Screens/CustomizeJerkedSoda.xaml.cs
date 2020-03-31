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
using Flavor = CowboyCafe.Data.SodaFlavor;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order order;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>

        public CustomizeJerkedSoda(object dc)
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
            JerkedSoda js = (JerkedSoda)DataContext;
            switch (((Button)sender).Name)
            {
                //Flavor Cases
                case "OrangeSodaButton":
                    js.Flavor = Flavor.OrangeSoda;
                    break;
                case "CreamSodaButton":
                    js.Flavor = Flavor.CreamSoda;
                    break;
                case "SarsparillaButton":
                    js.Flavor = Flavor.Sarsparilla;
                    break;
                case "BirchBeerButton":
                    js.Flavor = Flavor.BirchBeer;
                    break;
                case "RootBeerButton":
                    js.Flavor = Flavor.RootBeer;
                    break;

                //Size Cases
                case "SmallButton":
                    order.subtotalFunc(js, Size.Small);
                    break;
                case "MediumButton":
                    order.subtotalFunc(js, Size.Medium);
                    break;
                case "LargeButton":
                    order.subtotalFunc(js, Size.Large);
                    break;
                default:
                    throw new NotImplementedException("Unknown Jerked Soda Toggle Button Pressed");
            }
            order.InvokePropertyChanged();
        }
    }
}
