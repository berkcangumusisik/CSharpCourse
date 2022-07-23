
Add();
Add();
Add();
Add();
var result = Add2(3, 5);
Console.WriteLine(result);
var result2 = Add2(3);
Console.WriteLine(result2);

int number1 = 20;
int number2 = 100;
int result3 = Add3(number1, number2);
Console.WriteLine(result3);
Console.WriteLine(Multiply(2, 3, 2));
Console.WriteLine(number1);
Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
Console.ReadLine();
static void Add()
{
    Console.WriteLine("Added");
}

static int Add2(int num1 = 20, int num2 = 30)
{
    return num1 + num2;
}
static int Add3(int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int number1, int number2, int v)
{
    return number1 * number2;
}



static int Add4(int number, params int[] numbers)
{
    return numbers.Sum();
}

/*
* Metotlar bizi DRY(Don't Repeat Yourself) prensibine uymamızı sağlar.
* Metot Tanımlama
[ErişimBelirleyicisi] <GeriDönüşDeğeri> MetotAdi(Varsa Parametreler)
{
    // Metot için gereken kodlar.
}
* Default Parametreler 
- Metotların belli parametrelerine eğer değer girilmezse default değerleri kullanmayı sağlar.
- Metotların en sonunda kullanılır.
ref anahtar kelimesi ile parametreleri referans olarak kullanılır. 

Method Overlading
 * Metotların aşırı yüklenmesi kısaca, aynı metodun farklı şekillerde tanımlanarak farklı işleri aynı anda yapabilmesidir. C#’ta aynı sınıfın içinde iki veya daha fazla metot parametre tanımlamaları farklı olması şartı ile aynı ismi taşıyabilir.
 * 
 * params 
    Metotların değişken sayıda parametre almasına imkan veren bir anahtar kelimedir.
 */