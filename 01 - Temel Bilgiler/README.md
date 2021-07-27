# C# TEMEL BİLGİLERİ
## C# NEDİR?
- Microsoft tarafından geliştirilmiştir.
- C ve C++ ailesinin mirasıdır.
- Orta seviye bir programlama dilidir.
- C# tasarım ekbinin başında *Anders Hejlsberg* bulunmaktadır. 
- Söz dizimi(Syntax) olarak Java ve sonrasında C , C++ kurallarını örnek almıştır.
- C# basit , modern , genel amaçlı ve nesneye yönelik programlama dili olarak tasarlanmıştır.

## C# GENEL ÖZELLİKLERİ
- Basit ve genel amaçlı bir dil
- Platformdan bağımsız bir dil
- Kullanımı kolay modern bir dil
- % 100 Nesneye yönelik programlama dili
- Gelecek tabanlı uygulamalar için uygun ve sağlam bir dil
- Çöp toplama ve kaynak yönetimi ile programların belleğini çok daha verimli kullanan bir dil

## C# İLE NELER YAPILABİLİR?
- Konsol uygulaması geliştirme
- Windows uygulaması geliştirme
- NET uygulaması geliştirme
- Web servisleri yazma
- Mobil uygulama geliştirme (PDA, cep telefonları vb. için)
- DLL yazma
ve daha bir çok uygulamayı rahatlıkla yapılabilir.

## C# TEMEL YAPISI

```
using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
    
        }
    }
}

```
- Yazılacak kodlar Main metodu içerisine yazılır.
- ```Console.WriteLine()``` ekrana bir şey bastırmamızı sağlar.
- ``` Console.ReadLine()```bir tuşa basmadan console uygulamasını kapatmaz.

## HELLO WORLD UYGULAMASI

```
using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
```
bu kodun çıktısı şu şekilde olacaktır.

![image](https://user-images.githubusercontent.com/75336900/127192601-101440a2-48b8-4eca-a86b-f4d1b44e72f2.png)
Ayrıca bu konsol uygulaması bir tuşa basılana dek açık kalacaktır.
