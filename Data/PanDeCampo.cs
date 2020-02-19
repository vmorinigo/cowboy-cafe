/*
   * Author: Valeria Morinigo
   * Class: PanDeCampo
   * Purpose: A class representing the PanDeCampo
   */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
   
    public class PanDeCampo : Side
    {
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Large:
                    return "Large Pan de Campo";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
