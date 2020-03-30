/*
   * Author: Valeria Morinigo
   * Class: PecosPulledPork
   * Purpose: A class representing the PecosPulledPork
   */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    
    public class PecosPulledPork : Entree
    {

        private bool bread = true;
        /// <summary>
        /// If the pulled pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value;
                NotifyOfPropertyChanged("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the pulled pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                NotifyOfPropertyChanged("Pickle");
            }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
