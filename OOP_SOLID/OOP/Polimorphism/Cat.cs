using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Polimorphism
{
    public class Cat : Animal
    {
        public override string Cry()
        {
            return "Meow";
        }
    }
}
