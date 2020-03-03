/*
  * Author: Nathan Bean
  * Class: Abstract class Side
  * Purpose: A base class representing a side
  */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
   
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}

    }
}
