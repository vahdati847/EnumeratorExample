﻿using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var inventory = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

        inventory.Add(new Product(1, "IPhone"));
        inventory.Add(new Product(2, "IPhone"));
        inventory.Add(new Product(3, "IPhone"));
        inventory.Add(new Product(4, "IPhone"));

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }
}


