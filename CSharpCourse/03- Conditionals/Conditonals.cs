using System;

namespace _03__Conditionals
{
    class Conditonals
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if(number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10");
            }




            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10");
                    break;
            }

            if(number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 -100");
            }
            else if(number > 100 && number<=200)
            {
                Console.WriteLine("Number is between 101 -200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number less than 0 or greater than 200");
            }


            if (number <100)
            {
                if(number >=90 )
                {

                }
            }
            Console.ReadLine();
        }
    }
}

/* *
 * if(sart)
 * {
 *      Eğer şart doğruysa yapılacak işlemler
 * }
 * else if (sart2)
 * {
 *      Eğer şart2 doğruysa yapılacak işlemler
 * }
 * else{
 *      Hiçbir şart sağlamıyorsa yapılacak işlemler
 * }
 */


/*
 * switch(ifade)
    {
        case kontrol1:
            çalışacak işlemler;
            break;
        case kontrol2:
            çalışacak işlemler;
            break;
        default:
            çalışacak işlemler;
            break;
    }
 
 */ 