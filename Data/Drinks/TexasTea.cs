/*
   * Author: Valeria Morinigo
   * Class: TexasTea
   * Purpose: A class representing the TexasTea
   */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        private bool sweet = false;
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyOfPropertyChanged("Sweet");
            }
        }

        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
            }
        }

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

        public override uint Calories
        {
            get
            {
                if(!Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
                switch (Size)
                {
                    case Size.Small:
                        return 10;
                    case Size.Medium:
                        return 22;
                    case Size.Large:
                        return 36;
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if(Sweet)
                    {
                        return "Small Texas Sweet Tea";
                    }
                    return "Small Texas Plain Tea";
                case Size.Medium:
                    if (Sweet)
                    {
                        return "Medium Texas Sweet Tea";
                    }
                    return "Medium Texas Plain Tea";
                case Size.Large:
                    if (Sweet)
                    {
                        return "Large Texas Sweet Tea";
                    }
                    return "Large Texas Plain Tea";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
