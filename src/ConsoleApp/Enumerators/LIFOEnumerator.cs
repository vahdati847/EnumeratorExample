using ConsoleApp.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products { get; set; }
    int position;
    public LIFOEnumerator(List<Product> products)
    {
        _products = products;
        Reset();
    }
        
    public Product Current => _products[position];

    object IEnumerator.Current
    {
        get 
        { 
            return Current; 
        } 
    }

    public void Dispose()
    {
        _products = null!;
    }

    public bool MoveNext()
    {
        position--;
        return position > -1;
    }

    public void Reset()
    {
        position = _products.Count;
    }
}
