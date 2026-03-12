using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4, 4, 5 };

        var result = numbers
                     .GroupBy(x => x)
                     .OrderByDescending(g => g.Count())
                     .First();

        Console.WriteLine("So xuat hien nhieu nhat: " + result.Key);
    }
}