using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class BakedBeansINotifyTest
    {
        [Fact]
        public void BakedBeansImplementsINotifyPropertyChanged()
        {
            var bak = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bak);
        }
    }
}
