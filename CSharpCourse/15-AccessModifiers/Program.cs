using System;

namespace _15_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int id { get; set; }
        public void Save()
        {
            

        }
        public void Delete()
        {

        }
    }

    class Student:Customer
    {
        public void Save2()
        {
            
        }
    }

    internal class Course
    {
        public string Name { get; set; }
    }
}

/*
 * private sadece tanımlandığı blok içinde kullanım sağlar.
 * protected'ın private farkı inheritence yapılan yerde kullanılabilir.
 * internal referans ihtiyacı olmadan kullanılır. Aynı assembly üzerinde olmalıdır.
 * public farklı projede kullanım imkanı sağlar. Referans ile çalışır.
 */