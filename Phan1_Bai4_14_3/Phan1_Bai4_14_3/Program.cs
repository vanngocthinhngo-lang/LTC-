using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var giamDan = numbers.OrderByDescending(n => n);

        foreach (var n in giamDan)
        {
            Console.WriteLine(n);
        }
    }
}