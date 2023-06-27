using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._27Q2
{
    internal class array
    {
        public void method()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("max value is "+max);
            Console.WriteLine("min value is " + min);
        }


    }
}
