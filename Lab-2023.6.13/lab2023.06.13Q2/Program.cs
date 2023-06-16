using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._06._13Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create the below mentioned console application and display it to the user. If user need to do an Addition user need to 
             insert 1 as the choice. For subtraction it should be 2 etc. Your program should contain a separate class call "CalculateValues"
            and inside the class you should add four methods which perform four arithmetic operations. All the methods should take two
            parameters which are user inserted numbers. And at the end of the method return the answer out of the method. 
            In main class if user want to do an addition call only the addition method in separate class. If user want to do a subtraction 
            call only the subtraction method in separate class. Etc. And display the final answer as shown in the figure 01.*/


            Console.WriteLine("Enter 1 for  addition");
            Console.WriteLine("Enter 2 for  substraction");
            Console.WriteLine("Enter 3 for  multiplication");
            Console.WriteLine("Enter 4 for  division");

            Console.Write("Enter your choice:");
            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter n1:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2:");
            double n2 = double.Parse(Console.ReadLine());


            CalculateValues objCalculateValues = new CalculateValues();

            if(op==1)
            {
                double addition = objCalculateValues.add(n1,n2);
                Console.WriteLine("Your answer is:" + addition);

            }

            if (op == 2)
            {
                double substraction = objCalculateValues.sub(n1, n2);
                Console.WriteLine("Your answer is:" + substraction);

            }
            if (op == 3)
            {
                double multiplication = objCalculateValues.mul(n1, n2);
                Console.WriteLine("Your answer is:" + multiplication);

            }
            if (op == 4)
            {
                double division = objCalculateValues.div(n1, n2);
                Console.WriteLine("Your answer is:" + division);

            }
            Console.ReadKey();
        }
    }
}
