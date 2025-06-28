using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.LiskovSubstitution
{
    //"Objects of a superclass should be replacable with objects of its subclass without acffecting the correctness of the program
    public class Rectangle : Shape 
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public override double Area => Width * Height;
    }
}
