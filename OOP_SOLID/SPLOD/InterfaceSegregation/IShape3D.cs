using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.InterfaceSegregation
{
    //"Clients should not be forced to depend on interfaces they do not use
    internal interface IShape3D
    {
        public double Area();
        public double Volume();
    }
}
