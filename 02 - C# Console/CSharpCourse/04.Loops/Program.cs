//FOR DÖNGÜSÜ
Console.WriteLine("-----------FOR DÖNGÜSÜ----------------");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("----------------------------");
for (int i = 0; i < 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("----------------------------");

int toplam = 0;
for (int i = 0; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        toplam += i;
    }

}
Console.WriteLine("0'dan 100'e kadar olan çift sayıların toplamı {0}", toplam);
Console.WriteLine("----------------------------");
string[] isimler = { "Ahmet", "Mehmet", "Ayse", "Fatma" };
for (int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}

Console.WriteLine("----------------------------");

// Kullanıcıdan başlangıç, bitiş ve artış değerleri alarak tüm sayıları ekrana yazdırınız.
Console.WriteLine("Başlangıç değeri giriniz:");
int baslangic = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bitiş değeri giriniz:");
int bitis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Artış değeri giriniz:");
int artis = Convert.ToInt32(Console.ReadLine());
for (int i = baslangic; i <= bitis; i += artis)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------------------------");

//Arabalar dizisindeki en az 5 karakterli araba adını ekrana yazdırınız.
string[] arabalar = { "Mercedes", "BMW", "Ferrari", "Porsche", "Lamborghini" };
for (int i = 0; i < arabalar.Length; i++)
{
    if (arabalar[i].Length >= 5)
    {
        Console.WriteLine(arabalar[i]);
    }

}

Console.WriteLine("----------------------------");

for (int i = 1; i < 11; i++)
{
    for (int j = 1; j < i; j++)
    {
        int carpim = i * j;
        Console.WriteLine("{0} x {1} = {2}", i, j, carpim);
    }
}
Console.WriteLine("-----------WHILE DÖNGÜSÜ----------------");
int number = 5;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}

string isim = "";
while (string.IsNullOrEmpty(isim))
{
    Console.WriteLine("Lütfen isminizi giriniz:");
    isim = Console.ReadLine();
}
Console.WriteLine("Hoşgeldiniz {0}", isim);
Console.WriteLine("----------------------------");

//FOREACH
Console.WriteLine("-----------FOREACH DÖNGÜSÜ----------------");
string[] isimler2 = { "Ahmet", "Mehmet", "Ayse", "Fatma" };
foreach (string isim2 in isimler2)
{
    Console.WriteLine(isim2);
}

Console.WriteLine("--------DO WHILE--------");

do
{
    Console.WriteLine("Merhaba Do While");
} while (1 == 2);


//Asal Sayı Uygulaması
Console.WriteLine("Asal Sayı Uygulaması");
Console.WriteLine("Lütfen bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
bool asalMi = true;

if (sayi == 1)
{
    Console.WriteLine("1 sayısı asal değildir.");
}
else
{
    for (int i = 2; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            asalMi = false;
            break;
        }
    }
}

if (asalMi)
{
    Console.WriteLine("{0} sayısı asaldır.", sayi);
}
else
{
    Console.WriteLine("{0} sayısı asal değildir.", sayi);
}


//1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışınız.

var randomSayi = new Random();
int rastgeleSayi = randomSayi.Next(1, 100);
int hak = 5;
int tur = 0;
int tahmin;
double soruPuani = 100 / hak;
while (hak > 0)
{
    tur++;
    Console.WriteLine($"{tur}. hakkınızdasınız. Lütfen 1-100 arasında bir sayı giriniz:");
    tahmin = Convert.ToInt32(Console.ReadLine());
    hak--;
    if (tahmin == rastgeleSayi)
    {
        double puan = 100 - (soruPuani * (tur - 1));
        Console.WriteLine($"Tebrikler!  {0} sayısını {tur}. defada Bildiniz.", rastgeleSayi);
        Console.WriteLine($"Toplam Puanınız: {puan}");
        break;
    }
    else
    {
        if (hak == 0)
        {
            break;
        }
        if (tahmin > rastgeleSayi)
        {
            Console.WriteLine("Daha küçük bir sayı giriniz.");
        }
        else
        {
            Console.WriteLine("Daha büyük bir sayı giriniz.");
        }

    }

}

Console.WriteLine("Tahmininiz bitti. Puanınız: 0");

Console.WriteLine("----------BANKAMATİK UYGULAMASI-------");
string secim = "";
double bakiye = 0;
double ekhesap = 1000;
double ekhesapLimiti = 1000;
do
{
    Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçiminiz: ");
    secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            Console.WriteLine("bakiyeniz {0} TL", bakiye);
            Console.WriteLine("ek hesap bakiyeniz {0} TL", ekhesap);
            break;
        case "2":
            Console.Write("yatırmak istediğiniz miktar: ");
            double yatirilan = double.Parse(Console.ReadLine());

            if (ekhesap < ekhesapLimiti)
            {
                double ekhesaptankullanilan = ekhesapLimiti - ekhesap;
                if (yatirilan >= ekhesaptankullanilan)
                {
                    ekhesap = ekhesapLimiti;
                    bakiye = yatirilan - ekhesaptankullanilan;
                }
                else
                {
                    ekhesap += yatirilan;
                }
            }
            else
            {
                bakiye += yatirilan;
            }
            break;
        case "3":
            Console.Write("çekmek istediğiniz miktar: ");
            double cekilecekmiktar = double.Parse(Console.ReadLine());
            if (cekilecekmiktar > bakiye)
            {
                double toplam2 = bakiye + ekhesap;

                if (toplam2 >= cekilecekmiktar)
                {
                    Console.Write("ek hesap kullanılsın mı? (e/h)");
                    string ekhesaptercihi = Console.ReadLine();

                    if (ekhesaptercihi == "e")
                    {
                        Console.Write("paranızı alabilirsiniz.");
                        ekhesap -= (cekilecekmiktar - bakiye);
                        bakiye = 0;
                    }
                    else
                    {
                        Console.WriteLine("bakiyeniz yetersiz");
                    }
                }
            }
            else
            {
                Console.Write("paranızı alabilirsiniz.");
                bakiye -= cekilecekmiktar;
            }
            break;
        case "4":
            Console.WriteLine("çıkış");
            break;
        default:
            Console.WriteLine("hatalı seçim");
            break;
    }
} while (secim != "4");

Console.WriteLine("uygulamadan çıkıldı.");

/*
FOR DÖNGÜSÜ
* En çok kullandığımız döngüdür.
* Eğer istediğimiz işlemin tekrar sayısını biliyorsak kullanırız.
for (sayaç; koşul; sayaç artış işlemi)
{
    //Tekrar edilecek kod bloğu
},

WHILE DÖNGÜSÜ
* While döngüsü sağlanana kadar devam eder.
* Sayaç olması gerekir.
while (koşul){
    //Tekrar edilecek kod bloğu
}

FOREACH DÖNGÜSÜ
- Foreach döngüsü, dizi içerisindeki her bir elemanı tek tek dolaşır.
foreach (var değişken_adı in dizi_adı){
    //Tekrar edilecek kod bloğu
}

DO WHILE DÖNGÜSÜ
- En az bir kez çalışır.
do{
    //Tekrar edilecek kod bloğu
}while (koşul);
9*
Sabit Döngüler => FOR, FOREACH
Şartlı Döngüler => WHILE, DO WHILE
break; => Döngüden çıkış yapar.
continue; => Döngüden o değeri atlayarak devam eder.
*/