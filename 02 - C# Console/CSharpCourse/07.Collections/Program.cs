
using System.Collections;
/**
Koleksiyonlara neden ihtiyaç duyarız?
* Koleksiyonlar dizilere yaşayacağımız zorlukların üstesinden gelmeyi sağlar.
* Dizilerde esneme kolaylığı yoktur. 
* Koleksiyonlar tüm veri türlerini kabul edebilmektedir.
* Koleksiyonlarda eleman sınırı yoktur. Mevcut kapasitesi artırılabilir.
*/
string[] cities = new string[2] { "Ankara", "İstanbul" };
cities = new string[3];
Console.WriteLine(cities[0]);
/*
 ArrayList
 * Farklı değişken türlerini object türünde tutan, dinamik olarak büyüyüp küçülebilen koleksiyon türüdür.
 * Tip güvenli değildir.
 * .Add() eleman eklemeyi sağlar.
 * . Sort() sıralamayı sağlar.
 * .Reverse() tersten sıralamayı sağlar.
 */

ArrayList cities2 = new ArrayList();
cities2.Add("Ankara");
cities2.Add("İstanbul");
cities2.Add("Adana");
cities2.Add('A');
foreach (var city in cities2)
{
    Console.WriteLine(city);
}
cities2.Remove('A'); // Remove() diziden eleman silmeyi sağlar.
Console.WriteLine("Dizinin kapasitesi : " + cities2.Capacity);

Console.WriteLine("Dizinin eleman sayısı : " + cities2.Count);

//Console.WriteLine(cities2.Sort());
//Console.WriteLine(cities2.Reverse());

string kullaniciSecim = string.Empty;
ArrayList degerListesi = new ArrayList();
do
{
    Console.Clear();
    Console.WriteLine("Menü");
    Console.WriteLine("1 - Değer Ekle");
    Console.WriteLine("2 - Değer Listele");
    Console.WriteLine("3 - Değer Ara");
    Console.WriteLine("4 - Değer Düzenle");
    Console.WriteLine("5 - Değer Sil");
    Console.WriteLine("6 - Uygulama Çıkış");
    Console.Write("Seçiniz: ");
    kullaniciSecim = Console.ReadLine();

    switch (kullaniciSecim)
    {
        case "1":
            Console.Write("Lütfen eklemek istediğiniz değeri giriniz : ");
            string kullaniciDeger = Console.ReadLine();
            degerListesi.Add(kullaniciDeger);
            Console.WriteLine("Değeriniz başarılı bir şekilde eklendi");
            System.Threading.Thread.Sleep(2000);
            break;
        case "2":
            for (int i = 0; i < degerListesi.Count; i++)
            {
                Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
            }
            Console.WriteLine("Devam etmek için bir tuşa basınız.");
            Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("Aramak istediğiniz değeri giriniz");
            string kullaniciAramaDeger = Console.ReadLine();
            bool kontrol = degerListesi.Contains(kullaniciAramaDeger);
            if (kontrol)
            {
                int bulunanIndex = degerListesi.IndexOf(kullaniciAramaDeger);
                string bulunanDeger = degerListesi[bulunanIndex].ToString();
                Console.WriteLine("Değeriniz Bulundu : index sırası :{0} - Değer : {1}", bulunanIndex, bulunanDeger);
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlerde bir deger bulunamadı");
                // Eğer aradığı kriterde değer bulamadı ise kullanıcıya bu değeri listeye ekleyelim mi olarak sorun eger kullanıcı E derse listeye ekleyin. 
            }
            System.Threading.Thread.Sleep(2000);
            break;
        case "4":

            Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
            string kullaniciDuzenlenecekDeger = Console.ReadLine();

            Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz", kullaniciDuzenlenecekDeger);
            string kullaniciYeniDeger = Console.ReadLine();

            if (degerListesi.Contains(kullaniciDuzenlenecekDeger))
            {
                int kullaniciHedefIndex = degerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                degerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                Console.WriteLine("Değeriniz güncellendi");
            }
            else
            {
                Console.WriteLine("Aradığınız değer liste içerisinde bulunamadı");
            }

            System.Threading.Thread.Sleep(2000);

            break;
        case "5":
            Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz (E/H)");
            string kullaniciSilCevap = Console.ReadLine();

            if (kullaniciSilCevap.ToUpper() == "E")
            {
                degerListesi.Clear();
                Console.WriteLine("Tüm değerler silindi");
            }
            else
            {
                Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz");
                string kullaniciSilDeger = Console.ReadLine();
                if (degerListesi.Contains(kullaniciSilDeger))
                {
                    degerListesi.Remove(kullaniciSilDeger);
                    Console.WriteLine("Değeriniz Silindi");
                }
                else
                {
                    Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
                }
            }

            break;
        default:
            break;
    }
} while (kullaniciSecim != "6");

