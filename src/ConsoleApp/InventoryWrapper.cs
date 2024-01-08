using ConsoleApp.Enumerators;
using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> Products;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new List<Product>();
    }

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
        {
            var fifoProducts = new FIFOEnumerator(Products);
            return fifoProducts;
        }
        else
        { 
            var lifoProducts = new LIFOEnumerator(Products);
            return lifoProducts;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
