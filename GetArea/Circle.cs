using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    
    public class Circle : Shape
    {
        public Circle(double _radius)
        {
            radius = _radius;  
        }
        public override double GetArea()
        {
            return radius * pi * radius;
        }
    }
}
