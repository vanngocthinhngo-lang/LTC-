//using System;
//class Class5
//{
//    static void Main()
//    {
//        Console.InputEncoding = System.Text.Encoding.UTF8;
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.Write("Nhập Chuỗi kí tự:");
//        string input = Console.ReadLine();
//        if(input == null)
//        {
//            Console.WriteLine("Chuỗi Null");
//            return;
//        }
//        input = input.Trim();
//        string[] words = string.IsNullOrEmpty(input) ? null : input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        if(words == null)
//        {
//            Console.WriteLine("Không có từ nào!");
//            return;
//        }
//        string longest = words[0];
//        foreach(var w in words)
//        {
//            if(w.Length > longest.Length)
//            {
//                longest = w;
//            }
//        }
//        Console.WriteLine("Từ Dài Nhất:" + longest);
//        Console.WriteLine("Độ Dài:" + longest.Length);
//    }
//}