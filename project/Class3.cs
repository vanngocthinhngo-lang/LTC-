//using System;
//using System.Text;
//class Class3
//{
//    static void Main()
//    {
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Nhập số phần tử n:");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];
//        if(n > 0)
//        {
//            for(int i = 0; i < n; i++)
//            {
//                Console.Write($"arr[{i}] = ");
//                arr[i] = int.Parse(Console.ReadLine());         
//            }
//        }
//        if(arr == null)
//        {
//            Console.Write("Lỗi! Mảng chưa được khởi tạo!");
//            return;
//        }
//        int count = 0;
//        for(int i =0;i<arr.Length; i++)
//        {
//            if (arr[i]% 2 == 0)
//            {
//                count++;
//            }
//        }
//        Console.Write("Số Phần tử chẵn trong mảng là:" + count);
//    }
//}