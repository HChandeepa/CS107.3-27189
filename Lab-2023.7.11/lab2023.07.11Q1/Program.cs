using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._07._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Question 01

Create a class called "Employee" which has 3 private variables (empID, empName, empDesignation) and create getters and setters for each field. 
Please note that this has no main method since this is Just an added class to the console application. Inside the main class take user inputs for 
employer id employee name employee designation and pass values to added class and set values.
From getters return relevant values and print the following message from main method.

Hello-Employ name-Your Employee ID is EMPID-And You are-a EmpDesignation*/

            Employee empclass = new Employee();

            Console.WriteLine("Enter employee ID:");
            int empID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee name:");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter employee designation:");
            string empDesignation = Console.ReadLine();

            empclass.setempID(empID);
            empclass.setempName(empName);
            empclass.setempDesignation(empDesignation);

            Console.Write("Hello {0} ", empName);
            Console.Write("Your Employee ID is {0} ", empID);
            Console.Write("And You are an {0}", empDesignation);

            Console.ReadKey();


        }
    }
}
