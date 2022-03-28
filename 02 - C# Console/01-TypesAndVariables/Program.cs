using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C# Öğrenmeye Hoş Geldin.   ");
            Console.WriteLine("Merhaba Dünya!");
            string isim = "Berkcan";
            Console.WriteLine(isim);
            char kullaniciSecimi = 'A';
            Console.WriteLine(kullaniciSecimi);

            byte a = 4;
            Console.WriteLine(a);

            int sayi;
            sayi = 12;
            Console.WriteLine(sayi);

            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine("int Veri Tipinin En Fazla Alacağı değer:" + intMax);
            Console.WriteLine("int Veri Tipinin En Az Alacağı değer:" + intMin);
            
            double number1 = 2.1233455656;
            Console.WriteLine(number1);

            decimal number2 = 10.2M;
            Console.WriteLine(number2);

            float number3 = 10.2F;
            Console.WriteLine(number3);


            bool dogruMu = true;
            Console.WriteLine(dogruMu);

            DateTime date = DateTime.Now;
            Console.WriteLine(date);


            //TÜR DÖNÜŞÜMLERİ
            string str20 = "20";
            int int20 = 21;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);


            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //Çıktısı 41 

            int int22 = int20 + int.Parse(str20);//Çıktısı 41 

            var x = "Berkcan";
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}

/*
Console.Write() => Ekrana yazı bastırıp alt satıra geçmeden yanına yazmaya devam eder.
Console.WriteLine() => İstenen ifadeyi yazarak bir alt satıra geçer.
Console.ReadLine() bir tuşa basmadan console uygulamasını kapatmaz.
Değişken , bir bellek konumuna verilen addır ve değişken üzerinde yapılan tüm işlemler o bellek konumunu etkiler.
veriTipi değişkenAdi = deger ; şeklinde değişken tanımlaması yapılır.
*/

/*
VERİ TÜRLERİ
* String => metinsel ifadelerdir. "" içinde yazılır.
* char 
    * 2 byte yer kaplar. 
    * Tek karakter tutmayı sağlar.
    * Tek tırnak içerisinde yazılır.
* byte
    - 1 byte yer kaplar. 
    - 0 ile 255 arasında değer tutar.
    - Tam sayılardır.
* int
    - Tam sayıları ifade eder.
    - -2147483648 ile 2147483647 arasında değer alır.
    - .MinValue ile veri tipinin en küçük değerini buluruz.
    - .MaxValue ile veri tipinin en büyük değerini buluruz.
    - 32 bit yer kaplar.
* double 
    - Ondalıklı sayıları tutar.
    - Virgülden sonra 15 16 basamak tutar.
    - 8 byte yer kaplar.
* decimal 
    - Ondalıklı sayıları tutar.
    - Virgülden sonra 28 basamak tutar.
    - 16 byte yer kaplar.
* float 
    - Ondalıklı sayıları tutar.
    - 4 byte yer kaplar.
* bool
    - Mantıksal veri tipidir.
    - True ya da false değerini tutar.
* DateTime => zaman tutar.
*/

/* 
DEĞİŞKEN TANIMLAMA KURALLARI
 * Büyük küçük harfe duyarlıdır.
 * Değişken adları rakamla başlayamaz. int 3degisken = 3
 * Programlamaya özel isimler verilemez. string if ="";
 * Aynı kod bloğu birden çok kez tanımlanamaz.
 * Değişken ismi tanımlanırken büyük harf, küçük harf, _ veya rakam kullanılabilir.
*/