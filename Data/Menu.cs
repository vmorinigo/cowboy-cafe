using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static List<IOrderItem> items = new List<IOrderItem>();

        public static IEnumerable<IOrderItem> Entrees
        {
            get
            {
                foreach(IOrderItem i in items)
                {
                    if(i is Entree)
                    {
                        yield return i;
                    }
                }
            }
        }

        public static IEnumerable<IOrderItem> CompleteMenu { get { return items; } }

    }
}
