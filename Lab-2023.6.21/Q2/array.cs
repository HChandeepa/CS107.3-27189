using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._21Q2
{
    internal class array
    {
        public void myarray()
        {

            int[] narray = new int[10];
            float sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter value {0}: ", i);
                narray[i] = int.Parse(Console.ReadLine());
                sum += narray[i];
            }
            float avg = sum / 10;

            int max = narray[0];
            int min = narray[0];

            for (int i = 1; i < 10; i++)
            {
                if (narray[i] > max)
                    max = narray[i];

                if (narray[i] < min)
                    min = narray[i];
            }

            Console.WriteLine("Minimum value: " + min);
            Console.WriteLine("Maximum value: " + max);
            Console.WriteLine("Average value:" + avg);

            for(int i=9;i>=0;i--)
            {
                Console.Write("{0} ", narray[i]);
            }
        }
    }
}
