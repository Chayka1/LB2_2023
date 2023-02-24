using System;
using System.Collections.Generic;

class Program
{
    delegate int StringLengthDelegate(string s);

    static void Main(string[] args)
    {
        List<string> strings = new List<string> { "hello", "world", "foo", "bar", "baz" };

        // Створення делегата за допомогою лямбда-виразу
        StringLengthDelegate stringLengthDelegate = s => s.Length;

        // Використання делегата для обробки списку рядків
        foreach (string s in strings)
        {
            int length = stringLengthDelegate(s);
            Console.WriteLine($"Length of '{s}': {length}");
        }
    }
}
