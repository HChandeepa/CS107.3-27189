using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._23Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question 06 Take time to think and complete the question...

Create a Console application with two classes (Main class + another class).
Inside the main class take a user input which is the size of the array.
Pass the user inserted size as a parameter to the added class method. Inside the method create an integer array based on passed value from 
main method.Then take user inputs for the created array inside the separate class.Every user input value should be followed by value 0 inside 
the array.
Eg Assume array size is 9 and it should as follows*   {u input 0 u input 0  u input 0 u input}*/

            Console.WriteLine("Enter size of the array:");
            int no = int.Parse(Console.ReadLine());

            array objarray = new array();
            objarray.size(no);

            

            

            Console.ReadKey();
           
            


        }
    }
}
