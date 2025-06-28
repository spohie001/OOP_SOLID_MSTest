using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.LiskovSubstitution
{
    public class Square : Shape //Square is correctly modeldes as Shape see LSP_SquareCalculatesArea_ReturnsCorrctlyCalculated test
    {
        public double SideLength { get; set; }

        public override double Area => SideLength * SideLength;
    }
}
