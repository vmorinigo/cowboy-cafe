using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static List<IOrderItem> items = new List<IOrderItem>();

        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> e = new List<IOrderItem>();
            e.Add(new AngryChicken());
            e.Add(new CowpokeChili());
            e.Add(new DakotaDoubleBurger());
            e.Add(new PecosPulledPork());
            e.Add(new RustlersRibs());
            e.Add(new TexasTripleBurger());
            e.Add(new TrailBurger());
            return e;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> s = new List<IOrderItem>();
            s.Add(new BakedBeans());
            s.Add(new ChiliCheeseFries());
            s.Add(new CornDodgers());
            s.Add(new PanDeCampo());
            return s;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> d = new List<IOrderItem>();
            d.Add(new CowboyCoffee());
            d.Add(new JerkedSoda());
            d.Add(new TexasTea());
            d.Add(new Water());
            return d;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> m = new List<IOrderItem>();
            m.Add(new AngryChicken());
            m.Add(new CowpokeChili());
            m.Add(new DakotaDoubleBurger());
            m.Add(new PecosPulledPork());
            m.Add(new RustlersRibs());
            m.Add(new TexasTripleBurger());
            m.Add(new TrailBurger());
            m.Add(new BakedBeans());
            m.Add(new ChiliCheeseFries());
            m.Add(new CornDodgers());
            m.Add(new PanDeCampo());
            m.Add(new CowboyCoffee());
            m.Add(new JerkedSoda());
            m.Add(new TexasTea());
            m.Add(new Water());
            return m;
        }

    }
}
