using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        private bool roomForCream = false;
        /// <summary>
        /// If the coffee has cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

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

                if (Ice) instructions.Add("add ice");
                if (roomForCream) instructions.Add("Room For Cream");

                return instructions;
            }
        }
    }
}
