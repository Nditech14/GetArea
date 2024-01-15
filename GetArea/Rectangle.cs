using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class Rectangle : Shape
    {
        public Rectangle( double _width, double _height)
        {
            height = _height;
            width = _width;
        }

        

        public override double GetArea()
        {
            return width * height;
        }
    }
}
