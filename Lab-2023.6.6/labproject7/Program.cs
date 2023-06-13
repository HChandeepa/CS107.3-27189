using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace labproject7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*create a c# console application to convert user given kilo meter(km) value to meter(m) value.TAke a seperate class call "convertValues"
              and inside the class create a method call kilometrTometer(no return type No parametermethod).And display the answer within the method.
            Then create an object in main Class (program class) and call the method*/

            ConvertValues objConvertValues = new ConvertValues();
            objConvertValues.kilometerTometer();

            Console.ReadKey();



        }

    }
}
