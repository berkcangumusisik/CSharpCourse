using System;

namespace _16_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product
            {
                ID = 1,
                Name = "Laptop"
            };

            Product product1 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());

            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;
            Utilities.Validate();
        }
    }
    class CustomerManager
    {
        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items count!", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int ID, string Name)
        {
            _id = ID;
            _name = Name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            Entity = entity;
        }

        public string Entity { get; }

        public void Message(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
    
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public static void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}

/*
 * Constructor newlendiği zaman çalışabilir.
 * sınıf yapılarının nesne olarak tanımlanmasında alt yapıyı hazırlayan, kurucu rolü üstlenen, sınıf ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.
 * Tanımlama biçimine göre parametreli veya parametresiz kullanılabilir.


 */