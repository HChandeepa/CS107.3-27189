using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace labproject7
{
    internal class ConvertValues
    {
        public void kilometerTometer()
        {
            double km;
            Console.Write("Enter km:");
            km = double.Parse(Console.ReadLine());

            double meter = km * 1000;
            Console.WriteLine("Meter:"+meter);

        }

    }
}
