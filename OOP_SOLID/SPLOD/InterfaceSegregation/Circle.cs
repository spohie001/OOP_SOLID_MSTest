using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.InterfaceSegregation
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI *Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            throw new InvalidOperationException("Circle is 2D"); //forced to implement method that class will not use
        }
    }
}
