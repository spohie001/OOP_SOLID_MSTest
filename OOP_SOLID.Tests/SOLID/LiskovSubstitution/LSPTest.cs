using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_SOLID.SPLOD.LiskovSubstitution;

namespace OOP_SOLID.Tests.SOLID.LiskovSubstitution
{
    [TestClass]
    public class LSPTest
    {
        [TestMethod]
        public void LSP_RectangleCalculatesArea_ReturnsCorrctlyCalculated()
        {
            var rect = new Rectangle() { Width = 10, Height = 5 };
            Assert.AreEqual(50, rect.Area, "Expected 10 * 5 = 50");
        }
        [TestMethod]
        public void LSP_SquareCalculatesArea_ReturnsCorrctlyCalculated()
        {
            var rect = new Square() { SideLength = 5};
            Assert.AreEqual(25, rect.Area, "Expected 5 * 5 = 25"); 
        }
    }
}
