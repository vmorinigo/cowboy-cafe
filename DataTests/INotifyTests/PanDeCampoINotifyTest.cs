using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{ 
    public class PandeCampoINotifyTest
    {
        [Fact]
        public void PandeCampoImplementsINotifyPropertyChanged()
        {
            var pdc = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pdc);
        }
    }
}

