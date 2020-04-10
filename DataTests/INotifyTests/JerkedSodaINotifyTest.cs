using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaINotifyTest
    {
        [Fact]
        public void JerkedSodaImplementsINotifyPropertyChanged()
        {
            var js = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(js);
        }

        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIceAndSpecialInstructions()
        {
            var js = new JerkedSoda();
            Assert.PropertyChanged(js, "Ice", () => {
                js.Ice = false;
            });

            var js2 = new JerkedSoda();
            Assert.PropertyChanged(js2, "SpecialInstructions", () => {
                js2.Ice = false;
            });
        }
    }
}
