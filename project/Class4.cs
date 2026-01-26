//using System;
//class Class4
//{
//    static void Main()
//    {
//        Console.InputEncoding = System.Text.Encoding.UTF8;
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.Write("Nhập Họ Tên:");
//        string input = Console.ReadLine();
//        if(input == null)
//        {
//            Console.Write("Null");
//            return;
//        }
//        input = input.Trim();
//        string[] parts = string.IsNullOrEmpty(input) ? null : input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        if(parts == null)
//        {
//            Console.WriteLine("Mảng kết quả null");
//            return;
//        }
//        Console.WriteLine("Kết quả tách:");
//        foreach(var p in parts)
//        {
//            Console.WriteLine(p);
//        }    
//    }
//}