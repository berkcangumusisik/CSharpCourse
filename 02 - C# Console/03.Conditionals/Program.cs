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
            if(sum > 50){
                Console.WriteLine("Girmiş olduğunuz sayıların toplamı 50'den büyüktür.");
            }
        }
    }
}
/*
KOŞULLU İFADELER 
if(şart/Şartlar (&& ||)){
    //Eğer şart veya şartlar doğruysa çalışır.
}
*/
