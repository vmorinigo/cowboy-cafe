/*
  * Author: Valeria Morinigo
  * Class: RustlersRibs
  * Purpose: A class representing the RustlersRibs
  */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
  
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// No special instructions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
