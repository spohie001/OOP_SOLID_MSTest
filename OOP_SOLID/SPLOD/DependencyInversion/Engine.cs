﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.DependencyInversion
{
    internal class Engine : IEngine
    {
        public string Start()
        {
            return "Started";
        }
    }
}
