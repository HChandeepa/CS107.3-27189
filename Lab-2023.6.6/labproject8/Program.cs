using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labproject8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* modify the same defined method to method which accept a parameter value. that parameter value is the user given KM value
             (NO return type with parameters method).Display the answer using the class object.*/
            Console.WriteLine("enter KM:");
            double km = double.Parse(Console.ReadLine());

            ConverValues obj = new ConverValues();
            obj.kilometerTometer(km);
            Console.ReadKey();

        }
    }
}
