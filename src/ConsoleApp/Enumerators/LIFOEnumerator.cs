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
        position = _products.Count - 1;
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
        position--;
        return position >= 0;
    }

    public void Reset()
    {
        position = _products.Count -1 ;
    }
}
