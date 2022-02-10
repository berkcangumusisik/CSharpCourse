using System;

namespace _23_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1, LastName = "Gümüşışık", Age = 22};
            CustomerDal customerDal = new CustomerDal(); 
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        [Obsolete("Don't use Add,instead use AddNew Method")]
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }


    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Property ,AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {
        
    }
}
/*
 * Attributeler davranışı değiştirmeye çalışan sınıflardır. Mesela tabloda bir alanın boş geçilmemesi için kullanılabilir.
 * class SampleAttribute : Attribute
   {
   
   }
 * AttributeTargets.All : tüm her yerde kullanabilirsin demektir.
 * AllowMultiple = Birden fazla kullanılabilir mi?
 * Attribute bir yerde kullanılacaksa [] kullanılır.
 */