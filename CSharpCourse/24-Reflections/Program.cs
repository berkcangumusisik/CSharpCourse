﻿using System;
using System.Reflection;

namespace _24_Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));
            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type, 6, 7);
            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            var metotlar = type.GetMethods();
           
            foreach (var info in metotlar)
            {
                Console.WriteLine("Metot adı : {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre adı : {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine(("Attribute : {0}",attribute.GetType().Name));
                }
            }
            Console.ReadLine();
        }

        public class DortIslem
        {
            private int _sayi1;
            private int _sayi2;

            public DortIslem(int sayi1 , int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2; 
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }
            [MetodName("Carp")]
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }


        }
    }

    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
/*
 * Bir programın çalıştırılması sırasında dinamik olarak tip oluşturma, yükleme ve kullanılması işlemidir.
 * Nesneler hakkında bilgi almayı sağlar.
 * Özelliklere liste şeklinde .GetMethods() ile  ulaşmayı sağlar.
 * Metodun parametrelerine ulaşmak için .GetParameters() kullan.
 *
 */