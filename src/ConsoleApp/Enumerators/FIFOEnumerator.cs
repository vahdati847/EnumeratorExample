using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products { get; set; }
    int position;
    public FIFOEnumerator(List<Product> products)
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
        position++;
        return position < _products.Count;
    }

    public void Reset()
    {
        position = -1;
    }
}
