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
    /// Interaction logic for CustomizeTexasTea.xaml
    /// </summary>
    public partial class CustomizeTexasTea : UserControl
    {
        /// <summary>
        /// This variable is used so I can notify the properties have changed
        /// </summary>
        private Order order;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="dc">Datacontext: This is the overall order so I can trigger the special properties for the order</param>
        public CustomizeTexasTea(object dc)
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
            TexasTea tt = (TexasTea)DataContext;
            switch (((RadioButton)sender).Name)
            {
                case "SmallButton":
                    order.subtotalFunc(tt, Size.Small);
                    SmallButton.IsChecked = true;
                    break;
                case "MediumButton":
                    order.subtotalFunc(tt, Size.Medium);
                    MediumButton.IsChecked = true;
                    break;
                case "LargeButton":
                    order.subtotalFunc(tt, Size.Large);
                    LargeButton.IsChecked = true;
                    break;
                default:
                    throw new NotImplementedException("Unknown Texas Tea Toggle Button Pressed");
            }
            order.InvokePropertyChanged();
        }
    }
}
