using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Зчитуємо дані з файлу та створюємо список студентів
        using (StreamReader reader = new StreamReader("students.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                double averageGrade = double.Parse(parts[2]);
                students.Add(new Student(firstName, lastName, averageGrade));
            }
        }

        // Відфільтруємо студентів за середнім балом
        List<Student> filteredStudents = students.Where(s => s.AverageGrade >= 4.5).ToList();

        // Виведемо результат
        Console.WriteLine("Список студентів з середнім балом >= 4.5:");
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine("{0} {1}, середній бал: {2}", student.FirstName, student.LastName, student.AverageGrade);
        }
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double AverageGrade { get; set; }

    public Student(string firstName, string lastName, double averageGrade)
    {
        FirstName = firstName;
        LastName = lastName;
        AverageGrade = averageGrade;
    }
}
