using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.DependencyInversion
{
    //High-level modules should not depend on low-level modules. Both should depend on abstracion.
    internal interface IEngine
    {
        public string Start();
    }
}
