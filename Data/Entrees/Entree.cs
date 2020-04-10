/*
  * Author: Valeria Morinigo
  * Class: Abstract class Entree
  * Purpose: A base class representing a entree
  */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged 
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The is the screen associated with the IOrderItem
        /// </summary>
        public virtual object Screen { get; set; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Helper method to notify any changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
