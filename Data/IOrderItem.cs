﻿/*
  * Author: Valeria Morinigo
  * Interface: IOrderItem
  * Purpose: Represents a single item of an order
  */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface represeting a single item of an order 
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price od this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories od this order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// The is the screen associated with the IOrderItem
        /// </summary>
        public object Screen { get; set; }
    }
}
