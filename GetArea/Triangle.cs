using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetArea
{
    public class Triangle : Shape
    {
        public Triangle(double _height , double _width)
        {
            width = _width;
            height = _height;
        }

       

        public override double GetArea()
        {
            return  0.5 * height * width;
        }
    }
}
