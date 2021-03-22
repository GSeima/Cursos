using System;
using System.Collections.Generic;
using System.Text;
using TreinamentoDia4_Section10_136.Entities.Enum;

namespace TreinamentoDia4_Section10_136.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
