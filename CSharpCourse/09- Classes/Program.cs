using System;

namespace _09__Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            Console.WriteLine();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Berkcan";
            customer.LastName = "Gümüşışık";
            customer.City = "Ankara";

            Customer customer2 = new Customer
            {
                ID = 2,City="Ankara",FirstName="İbrahim", LastName="Gümüşışık"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }

}

/*
 * Bir class bittikten sonra yeni oluşturulabilir.
 * newlenerek çalışırlar.
 * Bir gruplama tekniğidir.
 * propertyleri /özellikleri tutar.
 */
