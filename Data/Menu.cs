/*
 * Author: Valeria Morinigo
 * Class: Menu
 * Purpose: A class representing the menu of the cafe
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees => new IOrderItem[]
        {
            new AngryChicken(),
            new CowpokeChili(),
            new DakotaDoubleBurger(),
            new PecosPulledPork(),
            new RustlersRibs(),
            new TexasTripleBurger(),
            new TrailBurger()
        };

        public static IEnumerable<IOrderItem> Sides => new IOrderItem[]
        {
            new BakedBeans(),
            new ChiliCheeseFries(),
            new CornDodgers(),
            new PanDeCampo()
        };

        public static IEnumerable<IOrderItem> Drinks => new IOrderItem[]
        {
            new CowboyCoffee(),
            new JerkedSoda(),
            new TexasTea(),
            new Water()
        };

        public static IEnumerable<IOrderItem> All => new IOrderItem[]
        {
            new AngryChicken(),
            new CowpokeChili(),
            new DakotaDoubleBurger(),
            new PecosPulledPork(),
            new RustlersRibs(),
            new TexasTripleBurger(),
            new TrailBurger(),
            new BakedBeans(),
            new ChiliCheeseFries(),
            new CornDodgers(),
            new PanDeCampo(),
            new CowboyCoffee(),
            new JerkedSoda(),
            new TexasTea(),
            new Water()
        };

        /// <summary>
        /// Gets the possible types of order
        /// </summary>
        public static string[] Types
        {
            get => new string[]
            {
            "Entrees",
            "Sides",
            "Drinks"
            };
        }

        /// <summary>
        /// Searches the database for matching menu items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            // Return all movies if there are no search terms
            if (terms == null) return All;
            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in All)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        
        /// <summary>
        /// Filters 
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="types">The type of order</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            // If no filter is specified, just return the provided collection
            if (types == null || types.Count() == 0) return items;
            // Filter the supplied collection of items
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if (item is Entree && types.Contains("Entrees"))
                {
                    results.Add(item);
                }
                if(item is Side && types.Contains("Sides"))
                {
                    results.Add(item);
                }
                if(item is Drink && types.Contains("Drinks"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">Minimum number for range of price</param>
        /// <param name="max">Maximum number for range of price</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of items
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="min">Minimum number for range of calories</param>
        /// <param name="max">Maximum number for range of caories</param>
        /// <returns>A collection containing only items that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
