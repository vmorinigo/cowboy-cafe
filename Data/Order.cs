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

        private List<IOrderItem> items = new List<IOrderItem>();

        private List<string> itemPrices = new List<string>();

        public IEnumerable<IOrderItem> Items { 
            get { 
                return items.ToArray(); 
            }
        }

        public IEnumerable<string> ItemPrices { 
            get { 
                return itemPrices.ToArray(); 
            } 
        }

        public double Subtotal { get; set; }

        public uint OrderNumber { get; set; }

        /// <summary>
        /// Public constructor that initializes the list
        /// </summary>
        /// <param name="i">The current order number</param>
        public Order(uint i)
        {
            items = new List<IOrderItem>();
            itemPrices = new List<string>();
            OrderNumber = i;
        }

        /// <summary>
        /// Adds an item to the order list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            double priceOfItem = item.Price;
            string priceOfItemAsCurrency = String.Format("{0:C}", priceOfItem);
            Subtotal += priceOfItem;

            items.Add(item);
            itemPrices.Add(priceOfItemAsCurrency);
            InvokePropertyChanged();
        }
        /// <summary>
        /// Removes an item from the order list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            double priceOfItem = item.Price;
            string priceOfItemAsCurrency = String.Format("{0:C}", priceOfItem);
            Subtotal -= priceOfItem;

            items.Remove(item);
            itemPrices.Add(priceOfItemAsCurrency);
            InvokePropertyChanged();
        }

        /// <summary>
        /// This method assists in updating the subtotal for changing sizes
        /// </summary>
        /// <param name="i">The item</param>
        /// <param name="new_size">The size the item is suppose to be</param>
        public void subtotalFunc(IOrderItem i, Size new_size)
        {
            Side s;
            Drink d;

            Subtotal -= i.Price;
            if (i is Side)
            {
                s = (Side)i;
                s.Size = new_size;
                Subtotal += s.Price;
            }
            else
            {
                d = (Drink)i;
                d.Size = new_size;
                Subtotal += d.Price;
            }
            itemPrices.RemoveAt(itemPrices.Count - 1);

            string priceOfItemAsCurrency = String.Format("{0:C}", i.Price);
            itemPrices.Add(priceOfItemAsCurrency);
        }

        public void InvokePropertyChanged()
        {
            /* Invoke all events to ensure you don't miss anything */
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
