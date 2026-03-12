using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

        var result = numbers.Distinct();

        foreach (var n in result)
        {
            Console.Write(n + " ");
        }
    }
}