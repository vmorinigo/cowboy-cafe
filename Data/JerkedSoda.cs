/*
   * Author: Valeria Morinigo
   * Class: Jerked Soda
   * Purpose: A class representing the Jerked Soda
   */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public SodaFlavor Flavor { get; set;}
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public override List<string> SpecialInstructions
        {
            get
            {
                var ingredients = new List<string>();

                if (!Ice) ingredients.Add("Hold Ice");

                return ingredients;
            }
        }
    }
}