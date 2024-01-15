using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public abstract class Shape
    {
        public double height;
        public double width;
        public const float pi = 3.14f;
        public double radius;
        public abstract double GetArea();
    }
}
