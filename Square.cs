using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Interface_Excercise
{
    public class Square : IShape
    {
        private double data { get; set; }

        public Square(double r)
        {
            data = r;
        }


        public double CalculateArea()
        {
            var result = data * data;
            return result;
        }

        public double CalculatePerimeter()
        {
            var result = 4 * data;
            return result;
        }
    }




}
