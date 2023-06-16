using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._6._13
{
    internal class findValues
    {
        public double findArea(double radius)// when returning return type is double at this project(void coverted to double)
        {
            
            double Area = (22 / 7) * radius * radius;
            return Area;


        }
        public double findCircumference(double radius)// when returning return type is double at this project(void coverted to double)
        {
            double circumference = 2 * (22 / 7) * radius;
            return circumference;

        }
    }

}
