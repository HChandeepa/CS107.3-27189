using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._06._21Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Add a separate class file to Console application program and create a method call private void sayHello().

Inside the method display hello world

main class create a class object and try to access the sayHello() method by using the class

Can you access the method? Explain why?*/

            hello objhello = new hello();
            objhello.sayHello();

            Console.ReadKey();

            /*Program is not working because of the class is private*/
        }
    }
}
