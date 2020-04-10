using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class WaterINotifyTest
    {
        [Fact]
        public void WaterImplementsINotifyPropertyChanged()
        {
            var w = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(w);
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Ice", () => {
                w.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var w = new Water();
            Assert.PropertyChanged(w, "Lemon", () => {
                w.Lemon = true;
            });
        }

        [Fact]
        public void ChangingIceOrLemonPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var w = new Water();

            Assert.PropertyChanged(w, "SpecialInstructions", () => {
                w.Ice = false;
            });

            Assert.PropertyChanged(w, "SpecialInstructions", () => {
                w.Lemon = true;
            });
        }
    }
}