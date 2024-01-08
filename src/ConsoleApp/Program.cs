using ConsoleApp.Models;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var approch = InventoryManagementApproach.LastInFirstOut;
        var inventory = new InventoryWrapper(approch);
        inventory.Add(new Product(1, "IPhone"));
        inventory.Add(new Product(2, "IPhone"));
        inventory.Add(new Product(3, "IPhone"));
        inventory.Add(new Product(4, "IPhone"));

        Console.WriteLine($"Enumerating products using a stack approach ({approch.ToString()}):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }


    }
}


