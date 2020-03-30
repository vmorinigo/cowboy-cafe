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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        private OrderControl orderControl;
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// This method adds the Texas Triple Burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }

        }

        /// <summary>
        /// This method adds the Dakota Double Burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// This method adds the Trail Burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// This method adds the Pecos Pulled Pork to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// This method adds the Rustlers Ribs to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// This method adds the Angry Chicken to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                screen.DataContext = entree;
                order.Add(entree);
                orderControl.SwapScreen(screen);
            }
        }

        /// <summary>
        /// This method adds sides to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSideToList(object sender, RoutedEventArgs e)
        {
            //Ensure the DataContext is an Order and not NULL
            if (DataContext is Order order)
            {
                if (sender is Button)
                {
                    IOrderItem item;
                    FrameworkElement screen = null;
                    var orderControl = this.FindAncestor<OrderControl>();

                    //Cast sender to button
                    Button b = (Button)sender;

                    //Filter which button was pressed based on name
                    switch (b.Name)
                    {
                        case "AddBakedBeans":
                            item = new BakedBeans();
                            break;
                        case "AddChiliCheeseFries":
                            item = new ChiliCheeseFries();
                            break;
                        case "AddCornDogs":
                            item = new CornDodgers();
                            break;
                        case "AddPanDeCampo":
                            item = new PanDeCampo();
                            break;
                        default:
                            throw new NotImplementedException("Unknown side button clicked");
                    }
                    screen = new CustomizeSide(DataContext);
                    screen.DataContext = item;
                    order.Add(item);
                    orderControl.SwapScreen(screen);
                }
            }
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        private void AddCowboyCafe_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"> The IOrderItem to add </param>
        /// <param name="screen"> The customization screen (or null for none) </param>
        void AddItemAndOpenCustomizationScreen (IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("");


                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }*/
    }
}
