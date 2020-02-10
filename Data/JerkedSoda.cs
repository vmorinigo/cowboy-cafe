using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private bool ice = true;
        /// <summary>
        /// If the cdrink has ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public override string Flavor
        {
            get
            {
                switch (SodaFlavor)
                {
                    case SodaFlavor.CreamSoda:
                        return 227;
                    case SodaFlavor.OrangeSoda:
                        return 269;
                    case SodaFlavor.Sarsaparilla:
                        return 367;
                    case SodaFlavor.BirchBeer:
                        return 367;
                    case SodaFlavor.RootBeer:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
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
        public override List<string> Ingredients
        {
            get
            {
                var ingredients = new List<string>();

                if (!ice) ingredients.Add("hold ice");

                return ingredients;
            }
        }
    }
}
