using System;
using System.Text;

namespace BaiTapGeneric
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return $"[Student: Name={Name}, Age={Age}]";
        }
    }

    class Class1
    {

        static void HienThi<T>(T thamSo)
        {

            Console.WriteLine($"Giá trị: {thamSo} | Kiểu dữ liệu: {thamSo.GetType().Name}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--- DEMO PHƯƠNG THỨC GENERIC --- \n");


            HienThi<int>(100);


            HienThi<double>(15.5);


            HienThi<string>("Chào Đà Nẵng!");


            object obj = DateTime.Now;
            HienThi(obj);


            Student sv = new Student("Nguyễn Văn A", 20);
            HienThi<Student>(sv);

            Console.WriteLine("\nẤn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}