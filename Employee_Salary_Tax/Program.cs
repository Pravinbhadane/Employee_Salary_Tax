// See https://aka.ms/new-console-template for more information
using Employee_Salary_Tax;

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee { Name = "Pravin", Salary = 50000 };
        Employee emp2 = new Employee { Name = "Pawan", Salary = 60000 };
        Employee emp3 = new Employee { Name = "Kartik", Salary = 55000 };

        double emp1GrossSalary = emp1.GetGrossSalary();
        double emp2GrossSalary = emp2.GetGrossSalary();
        double emp3GrossSalary = emp3.GetGrossSalary();

        Console.WriteLine($"Employee 1 Gross Salary: {emp1GrossSalary}");
        Console.WriteLine($"Employee 2 Gross Salary: {emp2GrossSalary}");
        Console.WriteLine($"Employee 3 Gross Salary: {emp3GrossSalary}");

        Employee.DisplayEmployeeCount();
    }
}
