using System;

namespace _10_Interfacas
{
    class Program
    {
        static void Main(string[] args)
        {
            // IntarfacesIntro();
            // Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { ID = 1, FirstName = "Berkcan", LastName = "Gümüşışık", Address = "Ankara" });

            Student student = new Student
            {
                ID = 1,
                FirstName = "Ahmet",
                LastName = "Mehmet",
                Departmant = "Computer Sciences"
            };
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

/*
 * Interface adlandırması I ile başlar. Mesela IPerson
 * Temel nesne oluşturup ondan implemente etmek için kullanırlar.
 * Soyut nesne olduğu için tek başına işe yaramazlar.
 * :IInterface şeklinde diğer classlara implemente edilir.
 * Intarfaceler newlenemez.
 * 
 */