using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._27Q1
{
    internal class array
    {
        public void method()
        {
            int[] arr = new int[10];
            float sum = 0;
            for(int i=0;i<10;i++)
            {
                Console.Write("Enter {0}:", i);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum of the values:" + sum);

        }
    }
}
