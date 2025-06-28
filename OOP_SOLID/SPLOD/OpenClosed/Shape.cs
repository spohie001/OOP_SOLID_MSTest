using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.OpenClosed
{
    //"Software entities should be open for extension but closed for modification."
    internal abstract class Shape
    {
        public abstract double CalculateArea(); //we can add new class Triangle without changing existing code
    }
}
