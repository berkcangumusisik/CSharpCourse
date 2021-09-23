using System;

namespace _02_Operators
{
    class AritmetikOperators
    {

        static void Main(string[] args)
        {
            //TOPLAMA +
            int sayi1 = 10;
            int sayi2 = 20;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            Console.WriteLine("-----------------");

            string metin1 = "Merhaba";
            int s3 = 10;
            string toplam2 = metin1 + s3;
            Console.WriteLine(toplam2);

            Console.WriteLine("-----------------");
            string metin2 = " Dünya";
            string toplam3 = metin1 + metin2;
            Console.WriteLine(toplam3);

            Console.WriteLine("-----------------");

            //ÇIKARMA -
            int cikar = sayi1 - sayi2;
            Console.WriteLine(cikar);

            Console.WriteLine("-----------------");

            byte b1 = 50;
            byte b2 = 100;
            int cikar2 = b2 - b1;
            Console.WriteLine(cikar2);
            Console.WriteLine("-----------------");


            //ÇARPMA *
            double d1 = 10.4;
            double d2 = 10.6;
            double carp = d1 * d2;
            Console.WriteLine(carp);
            Console.WriteLine("-----------------");

            int carp2 = (int)(carp);
            Console.WriteLine(carp2);
            Console.WriteLine("-----------------");


            //BÖLME /
            int s5 = 10;
            double s6 = 2;
            double bol = s5/s6;
            Console.WriteLine(bol);
            Console.WriteLine("-----------------");

            // Mod Alma %

            int mod = s5 % 3;
            Console.WriteLine(mod);

            Console.ReadLine();

        }
    }
}


/*
 * TOPLAMA OPERATÖRÜ(+)
 - int + int (toplama işlemi)
 - string + int(String Birleştirme)
 - int + string(String Birleştirme)
 - string + string(String Birleştirme)
++: 1 artırır.
-- : 1 azaltır.
 */