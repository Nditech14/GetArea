using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class Cone : Shape
    {
        

        public Cone(double _radius , double _height)
        {
            height = _height;
            radius = _radius;
        }
        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
    }
}
