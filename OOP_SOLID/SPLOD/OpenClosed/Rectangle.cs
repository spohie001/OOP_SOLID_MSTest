﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.OpenClosed
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Length * Height;
        }
    }
}
