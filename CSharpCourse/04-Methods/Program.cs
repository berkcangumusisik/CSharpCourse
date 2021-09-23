using System;
using System.Linq;

namespace _04_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            Add();
            Add();
            Add();
            var result = Add2(3, 5);
            Console.WriteLine(result);
            var result2 = Add2(3);
            Console.WriteLine(result2);

            int number1 = 20;
            int number2 = 100;
            var result3 = Add3(out number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,2));
            Console.WriteLine(number1);
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1=20, int number2=30)
        {
            return number1 + number2;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply( int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
        

    }
}


/*
 [ErişimBelirleyici] <GeriDonusDegeri> MetotAdi(Parametreler)
{
        //Metot için gereken kodlar.
}
 */

/*
 * Default değerler metotun en sonunda olmalı. Birden fazla verilebilir.
 */

/*
 ref : metotta tanımlanan değişken Main metodunda da  değiştirilirse değişmesini sağlar.
 ref ve out aynıdır ama ref 'de bir değer olmalı out ise böyle bir zorunluluk yoktur.
 */

/*Method Overlading
 * Metotların aşırı yüklenmesi kısaca, aynı metodun farklı şekillerde tanımlanarak farklı işleri aynı anda yapabilmesidir. C#’ta aynı sınıfın içinde iki veya daha fazla metot parametre tanımlamaları farklı olması şartı ile aynı ismi taşıyabilir.
 * 
 * params 
    Metotların değişken sayıda parametre almasına imkan veren bir anahtar kelimedir.
 */