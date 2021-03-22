using System;
using System.Collections.Generic;
using System.Text;
using TreinamentoDia4_Section10_136.Entities.Enum;

namespace TreinamentoDia4_Section10_136.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
