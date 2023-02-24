using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public int YearsOfExperience { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення списку об'єктів Employee
        List<Employee> employees = new List<Employee>()
        {
            new Employee() { Name = "John Smith", Salary = 50000, YearsOfExperience = 2 },
            new Employee() { Name = "Jane Doe", Salary = 60000, YearsOfExperience = 5 },
            new Employee() { Name = "Bob Johnson", Salary = 40000, YearsOfExperience = 1 },
            new Employee() { Name = "Mary Williams", Salary = 70000, YearsOfExperience = 8 }
        };

        // Сортування списку за зарплатою
        List<Employee> sortedList = employees.OrderByDescending(e => e.Salary).ToList();

        // Виведення результатів
        foreach (var employee in sortedList)
        {
            Console.WriteLine("{0}: ${1}", employee.Name, employee.Salary);
        }

        Console.ReadLine();
    }
}
