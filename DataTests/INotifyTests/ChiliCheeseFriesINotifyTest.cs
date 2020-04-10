using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class ChiliCheeseFriesINotifyTest
    {
        [Fact]
        public void ChiliCheeseFriesImplementsINotifyPropertyChanged()
        {
            var ccf = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ccf);
        }
    }
}
