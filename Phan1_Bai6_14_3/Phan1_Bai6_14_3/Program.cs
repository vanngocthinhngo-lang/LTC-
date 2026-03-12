using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        int dem = numbers.Count(n => n % 2 == 0);

        Console.WriteLine("So chan: " + dem);
    }
}