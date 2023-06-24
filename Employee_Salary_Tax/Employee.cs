using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Tax
{
    public class Employee
    {
        private static int totalEmployeeCount = 0; 
        private const double PT = 200; 

        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            
           Id = ++totalEmployeeCount;
        }

        public double GetGrossSalary()
        {
            return Salary - PT;
        }

        public static void DisplayEmployeeCount()
        {
            Console.WriteLine($"Total Employee Count: {totalEmployeeCount}");
        }
    }

   
}
