using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkINotifyTest
    {
        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var pec = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pec);
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var pec = new PecosPulledPork();
            Assert.PropertyChanged(pec, "Bread", () => {
                pec.Bread = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var pec = new PecosPulledPork();
            Assert.PropertyChanged(pec, "Pickle", () => {
                pec.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPickleOrBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pec = new PecosPulledPork();

            Assert.PropertyChanged(pec, "SpecialInstructions", () => {
                pec.Pickle = false;
            });

            Assert.PropertyChanged(pec, "SpecialInstructions", () =>
            {
                pec.Bread = false;
            });
        }
    }
}