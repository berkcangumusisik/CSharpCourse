
string[] students = new string[3];
students[0] = "Berkcan";
students[1] = "Şevval";
students[2] = "Nurana";
foreach (var student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("--------------------------------------------");
string[] students2 = { "Berkcan", "Şevval", "Nurana" };
foreach (var student in students2)
{
    Console.WriteLine(student);
}
Console.WriteLine("--------------------------------------------");

string[,] regions = new string[5, 3]
{
                {"İstanbul","İzmit","Tekirdağ"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("-------------------");

}
/*
 Diziler(Arrays)
- Aynı tipteki değişkenlere kolay ulaşım sağlar.
- Veri kümeleridir ve genel olarak bir trene benzetilir.
- Bellekte art arda aynı veri tipleri türünden değerler barındırır.
- Dizi tanımları [] ile yapılır.
 */

/* Çok Boyutlu Diziler
 * [,] eklenerek yapılır.
 * 2 boyutlu dizi için bir virgül bırakılır.
 */