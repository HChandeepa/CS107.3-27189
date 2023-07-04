using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._23Q1
{
    internal class array
    {
        public void size(int no)
        {
            int[] arr = new int[no];
           
            for (int i = 0; i <arr.Length; i++)
            {
                if(i%2==1)
                {
                    arr[i] = 0;
                }
                if(i%2==0)
                {
                    Console.WriteLine("Enter {0}:", arr[i]);
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nDisplay array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
    }
}
