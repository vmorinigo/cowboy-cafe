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
        //private static List<IOrderItem> items = new List<IOrderItem>();

        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> e = new List<IOrderItem>();
            e.Add(new AngryChicken());
            e.Add(new CowpokeChili());
            e.Add(new DakotaDoubleBurger());
            e.Add(new PecosPulledPork());
            e.Add(new RustlersRibs());
            e.Add(new TexasTripleBurger());
            e.Add(new TrailBurger());
            return e;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> s = new List<IOrderItem>();
            Side bakedbeans = new BakedBeans();
            Side mbakedbeans = new BakedBeans();
            Side lbakedbeans = new BakedBeans();
            Side chilicheesefries = new ChiliCheeseFries();
            Side mchilicheesefries = new ChiliCheeseFries();
            Side lchilicheesefries = new ChiliCheeseFries();
            Side corndog = new CornDodgers();
            Side mcorndog = new CornDodgers();
            Side lcorndog = new CornDodgers();
            Side pan = new PanDeCampo();
            Side mpan = new PanDeCampo();
            Side lpan = new PanDeCampo();
           
            mbakedbeans.Size = Size.Medium;
            lbakedbeans.Size = Size.Large;
            mchilicheesefries.Size= Size.Medium;
            lchilicheesefries.Size = Size.Large;
            mcorndog.Size = Size.Medium;
            lcorndog.Size = Size.Large;
            mpan.Size = Size.Medium;
            lpan.Size = Size.Large;


            s.Add(bakedbeans);
            s.Add(mbakedbeans);
            s.Add(lbakedbeans);
            s.Add(chilicheesefries);
            s.Add(mchilicheesefries);
            s.Add(lchilicheesefries);
            s.Add(corndog);
            s.Add(mcorndog);
            s.Add(lcorndog);
            s.Add(pan);
            s.Add(mpan);
            s.Add(lpan);

            return s;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            Drink coffee = new CowboyCoffee();
            Drink mcoffee = new CowboyCoffee();
            Drink lcoffee = new CowboyCoffee();
            Drink soda = new JerkedSoda();
            Drink msoda = new JerkedSoda();
            Drink lsoda = new JerkedSoda();
            Drink tea = new TexasTea();
            Drink mtea = new TexasTea();
            Drink ltea = new TexasTea();
            Drink water = new Water();
            Drink mwater = new Water();
            Drink lwater = new Water();
            List<IOrderItem> d = new List<IOrderItem>();
            d.Add(coffee);
            mcoffee.Size = Size.Medium;
            d.Add(mcoffee);
            lcoffee.Size = Size.Large;
            d.Add(lcoffee);

            d.Add(soda);
            msoda.Size = Size.Medium;
            d.Add(msoda);
            lsoda.Size = Size.Large;
            d.Add(lsoda);

            d.Add(tea);
            mtea.Size = Size.Medium;
            d.Add(mtea);
            ltea.Size = Size.Large;
            d.Add(ltea);

            d.Add(water);
            mwater.Size = Size.Medium;
            d.Add(mwater);
            lwater.Size = Size.Large;
            d.Add(lwater);
            return d;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> m = new List<IOrderItem>();
            m.Add(new AngryChicken());
            m.Add(new CowpokeChili());
            m.Add(new DakotaDoubleBurger());
            m.Add(new PecosPulledPork());
            m.Add(new RustlersRibs());
            m.Add(new TexasTripleBurger());
            m.Add(new TrailBurger());
            m.Add(new BakedBeans());
            m.Add(new ChiliCheeseFries());
            m.Add(new CornDodgers());
            m.Add(new PanDeCampo());
            m.Add(new CowboyCoffee());
            m.Add(new JerkedSoda());
            m.Add(new TexasTea());
            m.Add(new Water());
            return m;
        }

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
            if (terms == null) return CompleteMenu();
            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in Entrees())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            foreach (IOrderItem item in Sides())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            foreach (IOrderItem item in Drinks())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /*
        /// <summary>
        /// Filters 
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="types">The type of order</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            // If no filter is specified, just return the provided collection
            if (types == null || types.Count() == 0) return CompleteMenu();
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in CompleteMenu())
            {
                if (item.GetType().ToString() != null && types.Contains(item.GetType().ToString()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="min">Minimum number for range of rating</param>
        /// <param name="max">Maximum number for range of rating</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return CompleteMenu();
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in CompleteMenu())
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in CompleteMenu())
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in CompleteMenu())
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="min">Minimum number for range of rating</param>
        /// <param name="max">Maximum number for range of rating</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return CompleteMenu();
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in CompleteMenu())
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in CompleteMenu())
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in CompleteMenu())
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }*/
    }
}
