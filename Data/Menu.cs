/*
 * Author: Valeria Morinigo
 * Class: Menu
 * Purpose: A class representing the menu of the cafe
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        //public static List<IOrderItem> items = new List<IOrderItem>();

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
            Side bakedbeans = new BakedBeans();
            Side mbakedbeans = new BakedBeans();
            Side lbakedbeans = new BakedBeans();
            Side chilicheesefries = new ChiliCheeseFries();
            Side mchilicheesefries = new ChiliCheeseFries();
            Side lchilicheesefries = new ChiliCheeseFries();
            Side corndog = new CornDodgers();
            Side mcorndog = new CornDodgers();
            Side lcorndog = new CornDodgers();
            Side pan = new PanDeCampo();
            Side mpan = new PanDeCampo();
            Side lpan = new PanDeCampo();
           
            mbakedbeans.Size = Size.Medium;
            lbakedbeans.Size = Size.Large;
            mchilicheesefries.Size= Size.Medium;
            lchilicheesefries.Size = Size.Large;
            mcorndog.Size = Size.Medium;
            lcorndog.Size = Size.Large;
            mpan.Size = Size.Medium;
            lpan.Size = Size.Large;


            s.Add(bakedbeans);
            s.Add(mbakedbeans);
            s.Add(lbakedbeans);
            s.Add(chilicheesefries);
            s.Add(mchilicheesefries);
            s.Add(lchilicheesefries);
            s.Add(corndog);
            s.Add(mcorndog);
            s.Add(lcorndog);
            s.Add(pan);
            s.Add(mpan);
            s.Add(lpan);

            return s;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            Drink coffee = new CowboyCoffee();
            Drink mcoffee = new CowboyCoffee();
            Drink lcoffee = new CowboyCoffee();
            Drink soda = new JerkedSoda();
            Drink msoda = new JerkedSoda();
            Drink lsoda = new JerkedSoda();
            Drink tea = new TexasTea();
            Drink mtea = new TexasTea();
            Drink ltea = new TexasTea();
            Drink water = new Water();
            Drink mwater = new Water();
            Drink lwater = new Water();
            List<IOrderItem> d = new List<IOrderItem>();
            d.Add(coffee);
            mcoffee.Size = Size.Medium;
            d.Add(mcoffee);
            lcoffee.Size = Size.Large;
            d.Add(lcoffee);

            d.Add(soda);
            msoda.Size = Size.Medium;
            d.Add(msoda);
            lsoda.Size = Size.Large;
            d.Add(lsoda);

            d.Add(tea);
            mtea.Size = Size.Medium;
            d.Add(mtea);
            ltea.Size = Size.Large;
            d.Add(ltea);

            d.Add(water);
            mwater.Size = Size.Medium;
            d.Add(mwater);
            lwater.Size = Size.Large;
            d.Add(lwater);
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
