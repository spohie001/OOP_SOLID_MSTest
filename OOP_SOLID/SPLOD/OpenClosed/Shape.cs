using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.SPLOD.OpenClosed
{
    //"Software entities should be open for extension but closed for modification."
    internal class Shape
    {
        public ShapeType shapeType { get; set;}
        public double Radius {  get; set; }
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea() //if ShapeType adds new field logic of this func has to be changed
        {
            switch (shapeType)
            { 
                case ShapeType.Circle:
                    return Math.PI * Math.Pow(Radius, 2);
                case ShapeType.Rectangle:
                    return Length * Width;
                default:
                    throw new InvalidOperationException("Shape type not supported");
            }
        }
    }
}
