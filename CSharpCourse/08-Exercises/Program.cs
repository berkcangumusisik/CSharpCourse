﻿using System;

namespace _08_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise1();

            Exercise2();

        }

        private static void Exercise2()
        {
            Console.WriteLine("1. sayıyı giriniz:");
            var strS1 = Console.ReadLine();

            Console.WriteLine("2. sayıyı giriniz:");
            var strS2 = Console.ReadLine();

            decimal number1 = Convert.ToDecimal(strS1);
            decimal number2 = Convert.ToDecimal(strS2);


            var total = number1 + number2;
            var extraction = number1 - number2;
            var impact = number1 * number2;
            var divide = number1 / number2;
            var mode = number1 % number2;

            Console.WriteLine(total);
            Console.WriteLine(extraction);
            Console.WriteLine(impact);
            Console.WriteLine(divide);
            Console.WriteLine(mode);
        }

        private static void Exercise1()
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("İsminizi Giriniz:");
            var name = Console.ReadLine();

            Console.WriteLine("Soyisminizi Giriniz:");
            var surname = Console.ReadLine();

            Console.WriteLine("Doğum Yılınızı Giriniz:");
            var birthDate = Console.ReadLine();

            Console.Clear();

            var yil = Convert.ToInt32(birthDate);
            int now = 2021;
            int age = now - yil;
            Console.WriteLine("Merhaba " + name + " " + surname + " " + age + " Yaşındasınız");
        }
    }
}
