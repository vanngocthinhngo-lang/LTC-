//using System;
//using System.Text;
//class Class1
//{
//    static void Main()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Nhập số phần tử n: ");
//        int n = int.Parse(Console.ReadLine());

//        int[] arr = null;

//        if (n > 0)
//        {
//            arr = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"arr[{i}] = ");
//                arr[i] = int.Parse(Console.ReadLine());
//            }
//        }

//        if (arr == null)
//        {
//            Console.WriteLine("Lỗi: Mảng chưa được khởi tạo!");
//            return;
//        }

//        int sum = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            sum += arr[i];
//        }

//        Console.WriteLine("Tổng = " + sum);
//    }
//}
