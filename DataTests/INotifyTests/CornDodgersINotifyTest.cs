using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CornDodgersINotifyTest
    {
        [Fact]
        public void CornDodgersImplementsINotifyPropertyChanged()
        {
            var cd = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cd);
        }
    }
}