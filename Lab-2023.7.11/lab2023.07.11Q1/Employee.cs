using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2023._07._11
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public void setempID(int empIDfromUser)
        {
            empID = empIDfromUser;
        }
        public int getempID()
        {
            return empID;
        }
        public void setempName(string empNamefromUser)
        {
            empName = empNamefromUser;
        }
        public string getempName()
        {
            return empName;
        }
        public void setempDesignation(string empDesignationfromUser)
        {
            empDesignation = empDesignationfromUser;
        }
        public string getempDesignation()
        {
            return empDesignation;
        }
    }
}
