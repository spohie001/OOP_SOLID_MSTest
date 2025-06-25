using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Polimorphism
{
    public class Dog : Animal
    {
        public override string Cry()
        {
            return "Woof";
        }
    }
}
