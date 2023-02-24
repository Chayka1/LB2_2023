using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Підключення до бази даних та отримання списку продуктів
        List<Product> products = GetProductsFromDatabase();

        // Групування продуктів за категорією
        var groupedProducts = products.GroupBy(p => p.Category);

        // Виведення результатів групування на консоль
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"\t{product.Name} - {product.Price}");
            }
        }
    }

    // Функція для отримання списку продуктів з бази даних
    static List<Product> GetProductsFromDatabase()
    {
        List<Product> products = new List<Product>();
        // Логіка для підключення до бази даних та отримання списку продуктів
        return products;
    }
}

// Клас для представлення продукту
class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}
