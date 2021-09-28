using System;

namespace _06_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
        private static void ForEachLoop()
        {
            string[] students = { "Engin", "Derin", "Berkcan" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);

        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void ForLoop()
        {
            Console.WriteLine("**********For Döngüsü**********");
            // 1'den 100'e kadar olan tüm sayıları yazdırınız.
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------");

            // 1'den 100'e kadar olan tek sayıları yazdırınız.
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");

            // 100'den 1'e kadar olan çift sayıları yazdırınız.
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");

            //1 ile 100 arasındaki çift sayıların toplamını yazdırınız.
            int toplam = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1 ile 100 arasındaki çift sayıların toplamı : " + toplam);
        }
    }
}


// DÖNGÜLER
/** Bir işlemi belli bir sayıda veya bir şart gerçekleşince tekrar etmek için aynı kodların tekrar tekrar çalışmasını sağlarlar.
 */

// FOR DÖNGÜSÜ
/*
 * İşlemin tekrar sayısını biliyorsak kullanırız.
 for(sayaç;şart;sayaç artış işlemi)
{
    tekrar edilecek kodlar
}
 * */

/* While DÖNGÜSÜ
 * While döngüsü sağlanana kadar devam eder
 while(true)
{
    // Tekar edecek kodlar
}
 *Genelde sayaç olması gerekir.
 */

/*
 * do
      {

      } while (true);
 * while döngüsünden tek farkı şart sağlanmasa bile en az 1 kez o kod çalışır.
 */

/* FOREACH DÖNGÜSÜ
 foreach (var item in collection)
            {

            }
 - Dizi temellidir.
 - Sabit döngü türüdür.
 */