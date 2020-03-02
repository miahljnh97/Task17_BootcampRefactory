using System;
using System.Collections.Generic;

namespace Task17_BootcampRefactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan kata yang anda inginkan;");
            string str1 = Console.ReadLine();
            Console.WriteLine("\n");

            //Number 1
            var hello1 = str1.Capitalize();
            Console.WriteLine($"Capitalize : {hello1}");
            Console.WriteLine("\n");

            //Number2
            var hello2 = str1.SnakeCase();
            Console.WriteLine($"SnakeCase : {hello2}");
            Console.WriteLine("\n");

            //Number 3
            var hello3 = str1.KebabCase();
            Console.WriteLine($"KebabCase : {hello3}");
            Console.WriteLine("\n");

            //Number 4
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 6, 8, 8, 6, 9 };
            var grades = new[] { 87.5, 88.5, 60.5, 90.5, 88.5 };
            var mostNumbers = numbers.Mode();
            var mostGrades = grades.Mode();
            Console.WriteLine($"Mode of Numbers : {mostNumbers}");
            Console.WriteLine($"Mode of Grades : {mostGrades}");
            Console.WriteLine("\n");

            //Number 5
            Console.WriteLine("Masukkan angka yang anda inginkan;");
            int num = Convert.ToInt32(Console.ReadLine());
            var result = num.Convert();
            Console.WriteLine($"Convert Integer To String : {result}");
            Console.WriteLine("\n");

            //Number 6
            Console.WriteLine("Masukkan jumlah teks yang anda ingin pisahkan;");
            int num1 = Convert.ToInt32(Console.ReadLine());
            var tulisanPanjang1 = str1.Trim(num1);
            Console.WriteLine($"Trim Text : {tulisanPanjang1}");
            Console.WriteLine("\n");

            //Number 7
            Console.WriteLine("Masukkan jumlah teks yang anda ingin pisahkan;");
            int num2 = Convert.ToInt32(Console.ReadLine());
            var tulisanPanjang2 = str1.TrimWords(num2);
            Console.WriteLine($"Trim Words : {tulisanPanjang2}");
            Console.WriteLine("\n");
        }
    }

}
