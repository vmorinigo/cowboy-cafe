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

        /*public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>(); 

            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "TexasTripleBurger":
                            order.Add(new TexasTripleBurger());
                            orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                            break;

                    }
                }
            }
        }*/
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

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        private void AddCornDogs_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
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
    }
}
