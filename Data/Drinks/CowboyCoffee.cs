/*
   * Author: Valeria Morinigo
   * Class: Cowboy Coffee
   * Purpose: A class representing the CowboyCoffee
   */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        public bool RoomForCream { get; set; } = false;

        public new bool Ice { get; set; } = false;
        
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
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
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if(Decaf)
                    {
                        return "Small Decaf Cowboy Coffee";
                    }
                    return "Small Cowboy Coffee";
                case Size.Medium:
                    if (Decaf)
                    {
                        return "Medium Decaf Cowboy Coffee";
                    }
                    return "Medium Cowboy Coffee";
                case Size.Large:
                    if (Decaf)
                    {
                        return "Large Decaf Cowboy Coffee";
                    }
                    return "Large Cowboy Coffee";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
