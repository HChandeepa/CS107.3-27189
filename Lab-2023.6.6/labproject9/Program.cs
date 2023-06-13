using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labproject9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Modify the same user defined method to method which accept a parameter and return the answer at the end of the method. 
             You should return the calculated Meter value at the end of the method. 
            (With return type with parameter method). Display the answer by using class object.*/
            Console.WriteLine("Enter km:");
            double km = double.Parse(Console.ReadLine());

            ConvertValues objConvertValues = new ConvertValues();
            double m=objConvertValues.kilometerTometer(km);
            Console.WriteLine("meter:" + m);
            Console.ReadKey();



        }
    }
}
