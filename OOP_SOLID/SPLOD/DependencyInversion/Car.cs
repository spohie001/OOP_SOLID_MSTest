using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.DependencyInversion
{
    internal class Car
    {
        private Engine _engine;

        public Car()
        {
            _engine = new Engine(); //if we want to change type of engine we have to change source code
        }
        public void StartCar()
        {
            _engine.Start();
        }
    }
}
