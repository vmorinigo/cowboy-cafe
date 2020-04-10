using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeINotifyTest
    {
        [Fact]
        public void CowboyCoffeeImplementsINotifyPropertyChanged()
        {
            var cc = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cc);
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var cc = new CowboyCoffee();

            Assert.PropertyChanged(cc, "Ice", () => {
                cc.Ice = true;
            });
        }

        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var cc = new CowboyCoffee();

            Assert.PropertyChanged(cc, "Decaf", () => {
                cc.Decaf = true;
            });
        }

        [Fact]
        public void ChangingCreamPropertyShouldInvokePropertyChangedForCream()
        {
            var cc = new CowboyCoffee();

            Assert.PropertyChanged(cc, "RoomForCream", () => {
                cc.RoomForCream = true;
            });
        }
    }
}
