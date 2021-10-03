using System;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();
            string sentence = "My name is Berkcan";
            var result = sentence.Length;
            Console.WriteLine(result);
            var result2 = sentence.Clone(); //Yazıyı klonlar.

            bool result3 = sentence.EndsWith("n"); // Şununla mı bitiyor
            bool result4 = sentence.StartsWith("n");//Bunula mı başlıyor
            var result5 = sentence.IndexOf("name");//Verilen ifade hangi indexle başlıyor. Bulamazsa -1 ile döner. Birden çok varsa ilk değeri getirir.

            var result6 = sentence.IndexOf(" ");

            var result7 = sentence.LastIndexOf(" "); //Tersten indexini getirir.
            var result8 = sentence.Insert(0,"Hello, "); //İstenen indexe veri ekler.
            var result9 = sentence.Substring(3,5); //Belli elemanları almaı sağlar.
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,5);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);

            Console.WriteLine("Doğum Yılınızı Giriniz: ");
            string yilStr = Console.ReadLine();


        }

        private static void Intro()
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }


            string city2 = "İstanbul";
            string result = city + " " + city2;
            Console.WriteLine(result);
            Console.WriteLine("{0} {1}", city, city2);

        }
    }
}
/*
 STRING 
 * Verileri metinsel olarak tutmayı sağlar.
 * String veriler toplanabilir.
 * .Length() => string verinin karakter sayısını verir. Boşlukta bir karakterdir.
 * 
 */