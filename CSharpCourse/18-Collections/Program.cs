using System;
using System.Collections;
using System.Collections.Generic;

namespace _18_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList();
            List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Masa");
            dictionary.Add("Computer","Bilgisayar");
            Console.WriteLine(dictionary["Table"]);
            foreach (var item in dictionary)
            {
                    Console.WriteLine(item);
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));
            Console.WriteLine(dictionary.ContainsValue("Masa"));
            Console.ReadLine();

        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            Console.WriteLine(cities.Contains("Adana"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {ID = 1, firstName = "Berkcan"});
            customers.Add(new Customer {ID = 2, firstName = "Engin"});


            var customer1 = new Customer
            {
                ID = 3, firstName = "Şevval"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer {ID = 4, firstName = "Nurana"},
                new Customer {ID = 5, firstName = "Mete"}
            });
            //customers.Clear();
            Console.WriteLine(customers.Contains(customer1));
            var index = customers.IndexOf(customer1);
            Console.WriteLine(index);
            customers.Add(customer1);
            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine(index2);
            customers.Insert(0, customer1);

            customers.Remove(customer1);
            customers.RemoveAll(c => c.firstName == "Engin");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.firstName);
            }

            var count = customers.Count;
            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add("A");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

    }

    class Customer
    {
        public int ID { get; set; }
        public string firstName { get; set; }
    }
}

// newlediğimiz an yeni referans oluşur ve eski veriler gider.
/*
 ARRAYLİST
 * Günümüzde arrayler yerine daha çok koleksiyonları kullanıyoruz.
 * ArrayList listName = new ArrayList(); şeklinde tanımlanır.
 * .Add ile yeni eleman eklenir.
 * Her veri tipini ekleyebiliriz.
 * tip güvenli değildir.
 *
 List<>
 *List<veriTipi> cities = new List<veriTipi>(); şeklinde tanımlanır
 * .Add() ile veri eklenir.
 * Tip güvenlidir.
 * .Count ile eleman sayısı bulunur.
 * .Clear tüm listeyi temizler
 * .Contains Listede aradığımız değer var mı diye kontrol eder.
 * .IndexOf() aradığımız elemanın indeksini verir.
 * .LastIndexOf() aramaya sondan başlar.
 * .Insert() istenen indekse veri ekler.
 * .Remove() girdiğimiz listeden girdiğimiz veriyi arayarak ilk bulduğu veriyi siler.
 Dictionary
 * Dictionary koleksiyonunda ise Anahtar(Key) ve Değer(Value) olmak üzere iki değer çıkar.
 * Dictionary<string, string> dictionary = new Dictionary<string, string>() şeklinde tanımlanır.
 */