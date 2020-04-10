using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class RustlersRibsINotifyTest
    {
        [Fact]
        public void RustlersRibsImplementsINotifyPropertyChanged()
        {
            var rus = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(rus);
        }
    }
}