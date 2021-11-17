using System;

namespace _12_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer
                {
                    FirstName = "Berkcan"
                },
                new Student
                {
                    FirstName = "İbrahim"
                }, 
                new Person
                {
                    FirstName = "Hüseyin"
                }
            };
            foreach(var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }

        class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }



        class Customer : Person
        {
            public string City { get; set; }

        }
        class Student : Person
        {
            public string Departmant { get; set; }

        }
    }
}

/*
 INHERITANCE(KALITIM)
* Sınıflararası hiyerarşik yapı kurmak için kullanılır.
* Bir sınıftan türer.
* Kalıtım veren sınıfa Base Class denir.
* Bir sınıf tek bir sınıftan kalıtım alabilir.
* :Class şeklinde kullanılır.
 
 */