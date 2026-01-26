using System;
class Class6
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số phần tử:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Null");
            return;
        }
        string[] arr = new string[n];
        if(arr == null)
        {
            Console.WriteLine("Null");
            return;
        }
        for( int i = 0; i< n; i++)
        {
            Console.Write("nhập phần tử thứ " + (i + 1) + ":");
            arr[i] = Console.ReadLine();
        }
        int count = 0;
        foreach(var s in arr)
        {
            if(s!= null && !string.IsNullOrWhiteSpace(s))
            {
                count++;
            }
        }
        Console.WriteLine("Số Chuỗi khác null và khác rỗng:" + count);
    }
}