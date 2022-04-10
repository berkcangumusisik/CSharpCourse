using System;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan Veri Alma
            Console.WriteLine("Adınızı Giriniz.");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Merhaba " + isim);

            //Toplama
            int number1 = 10;
            int number2 = 15;
            Console.WriteLine(number1 + number2);

            //int + string
            string text = "10";
            string toplamStr1 = text + number1;
            Console.WriteLine(toplamStr1);

            // String + string
            string text2 = " Dünya";
            Console.WriteLine(text + text2);

            // Çıkarma Operatörü -
            Console.WriteLine(number2 - number1);

            //Çarpma Operatörü * 
            double d1 = 10.4;
            double d2 = 10;
            Console.WriteLine(d1 * d2);

            //Bölme Operatörü /
            Console.WriteLine(number2 / number1);

            // Mod alma %
            Console.WriteLine(number2 % number1);

            // ÖRNEK ALIŞTIRMA
            Console.Write("Adınız : ");
            string name = Console.ReadLine();

            Console.Write("Soyadınız : ");
            string surname = Console.ReadLine();

            Console.Write("Doğum Yılınız : ");
            string birthDate = Console.ReadLine();
            int birthYear = Convert.ToInt32(birthDate);
            int yas = DateTime.Now.Year - birthYear;
            string message = "Merhaba " + name + " " + surname + " " + yas + " yaşındasınız";
            Console.WriteLine(message);
            // KARŞILAŞTIRMA OPERATÖRLERİ
            /*
            > : büyüktür.
            < : küçüktür
            >= büyük eşittir
            <= küçük eşittir
            == eşittir
            != eşit değildir
            */

            //MANTIKSAL OPERATÖRLER
            // VE OPERATÖRÜ && => Her ikisinin doğru olduğu durumda true döner.
            string userName = "admin";
            string password = "123456";
            bool value1 = userName == "admin" && password == "123456";
            Console.WriteLine(value1);
            // VEYA OPERATÖRÜ || => En az birinin doğru olduğu durumda true döner.

            bool value2 = userName == "admin" || password == "123456";
            Console.WriteLine(value2);

            //DEĞİL !

            bool value3 = !(userName == "admin" || password == "123456");
            Console.WriteLine(value3);
        }
    }
}
/*
ARİTMETİK OPERATÖRLER
Toplama işlemi 
+ ile gösterilir.
int + int ise toplama işlemi yapar.
string + int = string
string + string = string
*/