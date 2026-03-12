using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var lonHon5 = numbers.Where(n => n > 5);

        foreach (var n in lonHon5)
        {
            Console.WriteLine(n);
        }
    }
}