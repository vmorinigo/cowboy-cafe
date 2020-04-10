using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleINotifyTest
    {
        [Fact]
        public void DakotaDoubleImplementsINotifyPropertyChanged()
        {
            var dak = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dak);
        }

        [Fact]
        public void ChangingBunPropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Bun", () => {
                dak.Bun = false;
            });
        }

        [Fact]
        public void ChangingKetchupPropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Ketchup", () => {
                dak.Ketchup = false;
            });
        }

        [Fact]
        public void ChangingMustardPropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Mustard", () => {
                dak.Mustard = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Pickle", () => {
                dak.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheesePropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Cheese", () => {
                dak.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoPropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Tomato", () => {
                dak.Tomato = false;
            });
        }

        [Fact]
        public void ChangingLettucePropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Lettuce", () => {
                dak.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoPropertyShouldInvokePropertyChangedForBread()
        {
            var dak = new DakotaDoubleBurger();
            Assert.PropertyChanged(dak, "Mayo", () => {
                dak.Mayo = false;
            });
        }

        [Fact]
        public void ChangingAnyPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dak = new DakotaDoubleBurger();

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Bun = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Mayo = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Lettuce = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Tomato = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Cheese = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Pickle = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Mustard = false;
            });

            Assert.PropertyChanged(dak, "SpecialInstructions", () => {
                dak.Ketchup = false;
            });
        }
    }
}
