using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.LiskovSubstitution
{
    public class Square : Rectangle //Rectangle cannot be replaced by Square see LSP_SquareCalculatesArea_ReturnsCorrctlyCalculated test
    {
        public override double Width
        {
            get => base.Width;
            set => base.Width = base.Height = value;
        }
        public override double Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }
}
