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
        private bool ice = true;
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChanged("Ice");
            }
        }
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
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    switch (Size)
                    {
                        case Size.Small:
                            return "Small Cream Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Cream Soda Jerked Soda";
                        case Size.Large:
                            return "Large Cream Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.OrangeSoda:
                    switch (Size)
                    {
                        case Size.Small:
                            return "Small Orange Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Orange Soda Jerked Soda";
                        case Size.Large:
                            return "Large Orange Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.Sarsparilla:
                    switch (Size)
                    {
                        case Size.Small:
                            return "Small Sarsparilla Jerked Soda";
                        case Size.Medium:
                            return "Medium Sarsparilla Jerked Soda";
                        case Size.Large:
                            return "Large Sarsparilla Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.BirchBeer:
                    switch (Size)
                    {
                        case Size.Small:
                            return "Small Birch Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Birch Beer Jerked Soda";
                        case Size.Large:
                            return "Large Birch Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }       
                 case SodaFlavor.RootBeer:
                    switch (Size)
                    {
                        case Size.Small:
                            return "Small Root Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Root Beer Jerked Soda";
                        case Size.Large:
                            return "Large Root Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}