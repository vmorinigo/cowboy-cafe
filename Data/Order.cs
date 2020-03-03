/*
  * Author: Valeria Morinigo
  * Class: Order
  * Purpose: A class representing an Order
  */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private uint lastOrderNumber;

        private List<IOrderItem> items = new List<IOrderItem>();
        
        public IEnumerable<IOrderItem> Items => items.ToArray(); //makes a copy

        public double Subtotal { get; set; }

        public uint OrderNumber { get; }
        /// <summary>
        /// Adds an item to the order list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// Removes an item from the order list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

    }
}
