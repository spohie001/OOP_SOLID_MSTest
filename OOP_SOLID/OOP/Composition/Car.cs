using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.OOP.Composition
{
    public class Car
    {
        private List<string> _actions = new List<string>();
        public List<string> Start()
        {
            var lights = new Lights();
            var engine = new Engine();
            var wheels = new Wheels();
            _actions.Add(lights.Light());
            _actions.Add(engine.Start());
            _actions.Add(wheels.Rotate());
            _actions.Add("Car set to motion");
            return _actions;
        }
    }
}
