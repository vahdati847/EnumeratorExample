using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products { get; set; }
    int position = -1;
    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
    }

    public Product Current 
    {
        get 
        {
            try
            {
                return _products[position];
            }
            catch 
            {
                throw new Exception("Current item not found");
            }
        }
    }

    object IEnumerator.Current
    {
        get 
        { 
            return Current; 
        }
    }

    public void Dispose()
    {
        _products.Clear();
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
