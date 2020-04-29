using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuSidesShouldContainExpected()
        {
            var sides = new List<IOrderItem>(Menu.Sides);
            Assert.Collection(
                Menu.Sides,
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );

        }
    }
}
