using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("------------");
            int number1 = 10;
            Console.WriteLine("Number is {0}", number1);
            Console.WriteLine("------------");
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine(" int Veri Tipinin En Fazla Alacağı değer:" + intMax);
            Console.WriteLine(" int Veri Tipinin En Az Alacağı değer:" + intMin);
            Console.WriteLine("------------");
            //long veri tipi
            long number2 = 2147483647;
            Console.WriteLine("Number is {0}", number2);
            Console.WriteLine("------------");
            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            Console.WriteLine(" int Veri Tipinin En Fazla Alacağı değer:" + longMax);
            Console.WriteLine(" int Veri Tipinin En Az Alacağı değer:" + longMin);
            Console.WriteLine("------------");
            //short veri tipi
            short number3 = 3265 ;
            Console.WriteLine("Number is {0}", number3);
            Console.WriteLine("------------");
            //byte veri tipi
            byte number4 = 160;
            Console.WriteLine("Number is {0}", number4);
            Console.WriteLine("------------");
            //bool veri tipi
            bool  conditon = false;
            Console.WriteLine(conditon);
            Console.WriteLine("------------");
            Console.ReadLine();
        }
    }
}
/*
 * Console.WriteLine() ekrana bir şey bastırmamızı sağlar.
Console.ReadLine() bir tuşa basmadan console uygulamasını kapatmaz.
*/


/*
 *DEĞİŞKEN NASIL TANIMLANIR?
 *  veriTipi değişkenAdi = deger ;
*/

/*
 int veri tipi
- Tam sayıları ifade eder.
- -2147483648 ile 2147483647 arasında değer alır.
- .MinValue ile veri tipinin en küçük değerini buluruz.
- .MaxValue ile veri tipinin en büyük değerini buluruz.
- 32 bit yer kaplar.


long veri tipi
- Tam sayılar için kullanılır.
- 9223372036854775807 ile -9223372036854775808 arasında değer alır
- int veri tipini kapsar ama 2 kat yer kaplar.
- 64 bit yer kaplar.


short veri tipi
- tam sayıları tutar.
- 16 bit yer tutar
- -32768 ile 32767 arasında değer alır.


byte veri tipi
- 8 bit yer kaplar. 
- 0 ile 255 arasında değer tutar.
- Tam sayılardır.


bool veri tipi
- Mantıksal veri tipidir.
- True ya da false değerini tutar.
*/