using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shape_Interface_Excercise
{
    public class Circle : IShape
    {

        private double data { get; set; }

        public Circle(double r)
        {
            data = r;
        }


        public double CalculateArea()
        {
            var result = Math.PI * (data * data);
            return result;
        }

        public double CalculatePerimeter()
        {
            var result = 2 * Math.PI * data;
            return result;
        }
    }
}
