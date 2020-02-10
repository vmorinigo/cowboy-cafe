/*
  * Author: Valeria Morinigo
  * Class: Abstract class Drink
  * Purpose: A base class representing a Drink
  */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual SodaFlavor SodaFlavor { get; set; }

        /// <summary>
        /// Gets the ingredients for the drink
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
