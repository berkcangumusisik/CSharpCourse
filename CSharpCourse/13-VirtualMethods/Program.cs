using System;

namespace _13_VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Added by default");

        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            // base.Add();
        }
    }

    class MySql : Database
    {

    }
}

/*
 Türetilmiş sınıfları yeniden kullanmamızı sağlar
 override edilmiş bir metot içerisinden metodun orijinalini (temel sınıf içerisindeki halini) çağırabilmek için base anahtar sözcüğü kullanılır.
 */