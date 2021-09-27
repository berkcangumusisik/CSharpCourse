using System;

namespace _05_Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Berkcan";
            
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("-------------------");

            string[] students2 = { "Engin", "Derin", "Berkcan" };

            foreach (var student1 in students2)
            {
                Console.WriteLine(student1);
            }
            Console.WriteLine("-------------------");

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Tekirdağ"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
            };

            for(int i= 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("-------------------");

            }



            Console.ReadLine();
        }
    }
}


/*
 Diziler(Arrays)
- Aynı tipteki değişkenlere kolay ulaşım sağlar.
- Veri kümeleridir ve genel olarak bir trene benzetilir.
- Bellekte art arda aynı veri tipleri türünden değerler barındırır.
- Dizi tanımları [] ile yapılır.
- string
 */


/* Çok Boyutlu Diziler
 * [,] eklenerek yapılır.
 * 2 boyutlu dizi için bir virgül bırakılır.
 */