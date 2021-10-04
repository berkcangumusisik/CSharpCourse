using System;

namespace _08_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise1();
            // Exercise2();
            // Exercise3();
            // Exercise4();



            Console.ReadLine();


        }

        private static void Exercise4()
        {
            Console.WriteLine("Kullanıcı Kodunuzu Giriniz:");
            var usercode = Console.ReadLine();
            if (usercode == "ABC" || usercode == "123" || usercode == "236" || usercode == "CMK")
            {
                Console.WriteLine("Kullanıcı girişiniz başarılı!");
            }
            else if (usercode == "HHH" || usercode == "BBB" || usercode == "MMM")
            {
                Console.WriteLine("Kullanıcı girişiniz yapılamadı. Hesabınız kitlenmiştir!");
            }
            else
            {
                Console.WriteLine("Hatalı Kullanıcı Girişi");

            }
        }

        private static void Exercise3()
        {
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            var username = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz:");
            var password = Console.ReadLine();
            if (username == "admin" && password == "123")
            {
                Console.WriteLine("Merhaba " + username + " Başarılı bir şekilde giriş yaptınız");
            }
            else
            {
                Console.WriteLine("Giriş başarışız. Kullanıcı adı ve şifrenizi kontrol ediniz");
            }
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
