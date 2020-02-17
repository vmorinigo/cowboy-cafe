using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        private bool lemon = false;
        /// <summary>
        /// If the water has lemons
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
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
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
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

                if (!Ice) instructions.Add("hold ice");
                if (lemon) instructions.Add("add lemon");

                return instructions;
            }
        }
    }
}
