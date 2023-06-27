using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._27Q3
{
    internal class array
    {
        public void method()
        {
            int[] arr = new int [] { 10, 30, 66, 99, 12, 03, 2, 1, 0, 6, 996 };
            
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length-1;j++)
                {
                    if (arr[j] < arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }


            Console.WriteLine("Decending order");
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

           
        }
    }
}
