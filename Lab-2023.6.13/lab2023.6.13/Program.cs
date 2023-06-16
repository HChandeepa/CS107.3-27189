using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._6._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*create a C# console application to find the area and the circumference of a circle.user should insert the radius value to
            the program . program should contain a seperate class call "FindValues". Inside the seperate class and add two methods call findArea 
            and findCircumference .Both theses methods are methods which takes parameters.As the parameter you should pass the radius value.By using 
            above two methods find the area  and the circumference of the circle and return the answer from both methods. create a class object in
            main class object in main class and call both methods and display the answers*/

            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());

            findValues objfindValues = new findValues();

            double Area = objfindValues.findArea(radius);
            Console.WriteLine("Area:" + Area);
            double circumference = objfindValues.findCircumference(radius);
            Console.WriteLine("Circumference:" + circumference);




            Console.ReadKey();
        }
    }
}
