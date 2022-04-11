using System;

namespace _03.Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı 1 değerini giriniz: ");
            string s1 = Console.ReadLine();
            Console.Write("Sayı 2 değerini giriniz: ");
            string s2 = Console.ReadLine();

            decimal number1 = Convert.ToDecimal(s1);
            decimal number2 = Convert.ToDecimal(s2);
            decimal sum = number1 + number2;
            if (sum > 50)
            {
                Console.WriteLine("Girmiş olduğunuz sayıların toplamı 50'den büyüktür.");
            }
            else if (sum == 50)
            {
                Console.WriteLine("Sayıların toplamı 50'dir");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayılar 50'den küçüktür.");
            }



            Console.Write("Hangi Ay : ");
            string ay = Console.ReadLine();
            switch (ay)
            {
                case "Ocak":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                case "Nisan":
                    Console.WriteLine("04");
                    break;
                case "Mayıs":
                    Console.WriteLine("05");
                    break;
                case "Haziran":
                    Console.WriteLine("06");
                    break;
                case "Temmuz":
                    Console.WriteLine("07");
                    break;
                case "Ağustos":
                    Console.WriteLine("08");
                    break;
                case "Eylül":
                    Console.WriteLine("09");
                    break;
                case "Ekim":
                    Console.WriteLine("10");
                    break;
                case "Kasım":
                    Console.WriteLine("11");
                    break;
                case "Aralık":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("1 - 12 arası değer giriniz");
                    break;
            }

            //Kullanıcı adı ve şifresini doğru giren kişi için giriş başarılı, diğer durumlarda yanlış yazdırınız.
            Console.Write("Kullanıcı adınızı giriniz : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "123")
            {
                Console.WriteLine("Merhaba girişiniz başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız, kullanıcı adınız veya şifreniz hatalı");
            }

            /*
            Sistem içerisinde giriş yapabilecek giriş kodları:
            ABC - 123 - 236 - CMK kullanıcı girişiniz başarılı
            HHH - BBB - MMM Kullanıcı girişiniz kilitlenmiştir.
            Bunların dışında ise hatalı kullanıcı kodu
            */

            Console.Write("Kullanıcı kodunuzu giriniz : ");
            string kullaniciKodu = Console.ReadLine();
            if (kullaniciKodu == "ABC" || kullaniciKodu == "123" || kullaniciKodu == "236" || kullaniciKodu == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı");
            }
            else if (kullaniciKodu == "HHH" || kullaniciKodu == "BBB" || kullaniciKodu == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz kilitlenmiştir");
            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı Kodu");
            }


            //DÖRT İŞLEM
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.Write("İşlem türünü seçiniz : ");
            string kullaniciSecim = Console.ReadLine();
            Console.Write("1.sayıyı giriniz : ");
            string number3 = Console.ReadLine();
            Console.Write("2.sayıyı giriniz : ");
            string number4 = Console.ReadLine();
            double n1 = Convert.ToDouble(number3);
            double n2 = Convert.ToDouble(number4);

            if(kullaniciSecim == "1")
            {
                double toplam = n1 + n2;
                Console.WriteLine("Toplam " + toplam);
            }
            else if(kullaniciSecim == "2")
            {
                double cikarma = n1 - n2;
                Console.WriteLine("Çıkarma " + cikarma);
            }
            else if(kullaniciSecim == "3")
            {
                double carp = n1 * n2;
                Console.WriteLine("Çarpım " + carp);
            }
            else if(kullaniciSecim == "4")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Bölen değer 0 olamaz");
                }
                else{
                    double bolum = n1 / n2;
                    Console.WriteLine("Kalan : " + bolum);
                }
            }
            else
            {
                Console.WriteLine("1 - 4 arası bir değer giriniz");
            }


            /*
            Not ortalaması sistemine hoş geldiniz
            Not1, not2 ve not3 değerlerini alarak ortalama hesaplattırınız.
            Ortalama < 45 ise kaldınız
            Ortalama 45'e eşit veya 70'den küçükse: ortalamayla geçtiniz.
            Ortalama 70'e eşit veya 90'dan küçük ise iyi ile geçtiniz.
            Ortalama 90 ile 100 arasındaysa : Başarılı bir şekilde geçtiniz.
            Ortalama değer 100 den büyükse yanlış değer girdiniz.
            */
            Console.WriteLine("Not hesaplamaya hoş geldiniz");
            Console.Write("Not 1 : ");
            string not1 = Console.ReadLine();
            Console.Write("Not 2 : ");
            string not2 = Console.ReadLine();
            Console.Write("Not 3 : ");
            string not3 = Console.ReadLine();

            decimal note1 = Convert.ToDecimal(not1);
            decimal note2 = Convert.ToDecimal(not2);
            decimal note3 = Convert.ToDecimal(not3);
            decimal ortalama = (note1 + note2 + note3) / 3;
            if(ortalama < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if(ortalama >=45 && ortalama < 70)
            {
                Console.WriteLine("Orta ile geçtiniz");
            }
            else if(ortalama >= 90 && ortalama <= 100)
            {
                Console.WriteLine("Başarıyla ile geçtiniz");
            }
            else
            {
                Console.WriteLine("Lütfen not değerlerinizi kontrol ediniz");
            }
        }
    }
}
/*
KOŞULLU İFADELER 
if(şart/Şartlar (&& ||)){
    //Eğer şart veya şartlar doğruysa çalışır.
}else if(şart2 / Şartlar2){
    //Eğer şart2 veya şartlar2 doğruysa çalışır.
}else{
    //Hiçbir kod bloğu doğru değilse çalışır.
}
* if olmadan else if ve else ifadeleri işe yaramaz.
* Else if ve else ifadeleri olmadan if tek başına bulunabilir.
* Birden fazla else if bloğu yer alabilir.


switch(ifade)
{
    case kontrol1:
        çalışacak olan işlemler
        break;

    case kontrol2:
        çalışacak olan işlemler
        break;
    default:
        çalışacak olan işlemler
        break;
}
}
*/
