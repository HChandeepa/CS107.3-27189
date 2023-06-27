using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._27Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a C# program to find the minimum and maximum values from a 2D array*/
            int[,] arr = new int[3, 3] { { 1, 3, 6 }, { 2, 6, 9 }, { 2, 10, 89 } };

            int min = arr[0, 0];
            int max = arr[0, 0];

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (arr[i,j]<min)
                    {
                        min = arr[i,j];
                    }
                    if (arr[i,j]>max)
                    {
                        max = arr[i,j];
                    }
                }
            }
            Console.WriteLine("Maximum value is:" + max);
            Console.WriteLine("Minimum value is:" + min);

            Console.ReadKey();

        }
    }
}
