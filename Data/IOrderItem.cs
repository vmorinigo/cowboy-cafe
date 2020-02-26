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
        /// Special Instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
