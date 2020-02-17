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
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Wether the drink has ice or not
        /// </summary>
        public bool Ice {get; set;} = true;

        /// <summary>
        /// Gets the special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
