using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            });
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students2 = new List<string> {"Berkcan", "Şevval", "Nurana", "Mete"};
            if (!students2.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Kayıt Bulunamadı");
            }
            else
            {
                Console.WriteLine("Kayıt Bulundu.");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[4]
                {
                    "Berkcan", "Şevval", "Nurana", "Mete"
                };
                students[4] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
/*
 * try
    {
        //Kendi yazdığımız kodların bulunduğu bloktur
    }
   catch (Exception e)
    {
       //Sistem içinde alınan hataların loglanması ve kullanıcıya daha açıklayıcı hata mesajları vermeyi sağlar.
    }
* .Message yardımıyla hatanın ne olduğunu yazdırırız. Ama bunu daha çok yazılımcı hatayı bulmak için yapar. Kullanıcıya vermek sıkıntı oluşturabilir.
 *
 */