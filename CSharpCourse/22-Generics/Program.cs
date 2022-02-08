using System;
using System.Collections.Generic;

namespace _22_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Berkcan"},new Customer{FirstName = "İbrahim"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {


    }
    interface IProductDal : IRepository<Product>
    {
        
    }

    class Customer
    {
        public string FirstName { get; set; } 

    }

    interface ICustomerDal:IRepository<Customer>
    {
        void Custom();
    }

    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}


/*
 * Genericler nesne bazlı değişim yaptırmayı sağlar.
 * Mesela aynı operasyonları hem customer için hem de product için yapmak yerine IRepository adında bir interface oluştur.
 * <T> : T tipi demektir. Bizim oluşturduğumuz veya .Net Framework içerisinde yer alan bir tiptir.
 * Interface, class, abstract class ve metotlar için genericler kullanılabilir.
 Generic Kısıtlar
 * Belirli tipleri yazmasını sağlamak için IRepository'ye where T:class, new() yazarak veri tiplerini yazmasını önleriz. IEntity eklenirse de veritabanında olmayan nesneyi kısıtlamayı sağlar.
 */