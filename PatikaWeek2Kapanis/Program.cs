
// 1. Aşağıdaki çıktıyı yazan bir program.
/*
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?");
*/

// 2. Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
/*
string metinselDeger = "Bu bir metinsel değerdir ve değeri: ";
int tamSayi = 15;

Console.WriteLine(metinselDeger + tamSayi);
*/

// 3. Rastgele bir sayı üretip , ekrana yazdırınız.
/*
Random random = new Random();
int rastgele = random.Next();

Console.WriteLine(rastgele);
*/

// 4. Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
/*
Random random = new Random();
int rastgele = random.Next();

Console.WriteLine(rastgele % 3); // Üçe bölümünden kalanını yazdırıyorum.
*/

// 5. Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
/*
Console.WriteLine("Lütfen kaç yaşında olduğunuzu giriniz?");
int yas = Convert.ToInt32(Console.ReadLine());

switch (yas)
{
    case < 18:
        Console.WriteLine("-");
        break;
    case > 18:
        Console.WriteLine("+");
        break;
    default:
        Console.WriteLine("=");
        break;
}
*/

// 6.  Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
/*
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
*/

// 7. Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
/*
Console.Write("Lütfen ilk sanatçıyı giriniz: ");
string isim1 = Console.ReadLine();

Console.Write("Lütfen ikinci sanatçıyı giriniz: ");
string isim2 = Console.ReadLine();

string isimDegistirme = ""; // Yer değiştirme işlemi için boş bir string değer tanımlıyorum.
isimDegistirme = isim2;
isim2 = isim1;
isim1 = isimDegistirme;

Console.WriteLine("Yeni sıralamaya göre ilk sanatçı: " + isim1);
Console.WriteLine("Yeni sıralamaya göre ikinci sanatçı: " + isim2);
*/

// 8. Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
/*
static void BenDegerDondürmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}

BenDegerDondürmem();
*/

// 9. İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
/*
static int AddNumbers(int a, int b)
{
    return a + b;
}

int result = AddNumbers(8, 6);
Console.WriteLine("Toplam -> "+ result);
*/

// 10. Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.(Bu soruya ilişkin kafamda soru işaretleri var)
/*
Console.WriteLine("Lütfen true ya da false yazınız: ");
string giris = Console.ReadLine();
string input = giris.ToLower();
TrueOrFalse(input);

static void TrueOrFalse(string input) // Kullanıcıdan alınan cevaba göre bir değer döndüren metot tanımlıyorum.
{
    if (input == "true")
    {
        Console.WriteLine("Girdiğiniz değer true.");
    }
    else if (input == "false")
    {
        Console.WriteLine("Girdiğiniz değer false.");
    }
    else
    {
        Console.WriteLine("Geçersiz bir giriş yaptınız.");
    }
}
*/
// 11. 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
/*
static void MostOld()
{
    Console.WriteLine("Lütfen yaş bilgilerini giriniz:");
    int yas1 = Convert.ToInt32(Console.ReadLine());    
    int yas2 = Convert.ToInt32(Console.ReadLine());
    int yas3 = Convert.ToInt32(Console.ReadLine());

    if (yas1 >= yas2 && yas1 >= yas3)
    {
        Console.WriteLine($"En yaşlınız {yas1} yaşındadır.");
    }
    else if (yas2 >= yas1 && yas2 >= yas3)
    {
        Console.WriteLine($"En yaşlınız {yas2} yaşındadır.");
    }
    else
    {
        Console.WriteLine($"En yaşlınız {yas3} yaşındadır");
    }
}

MostOld();
*/

// 12. Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
/*
double maxNumber = 0;
Console.WriteLine("Lütfen girmek istediğiniz kadar sayı giriniz sonlandırmak istediğiniz zaman 'son' yazmanız yeterli: ");

while (true)
{
    string input = Console.ReadLine();

    if (input.ToLower() == "son")
    {
        break;
    }
    if (double.TryParse(input, out  double newNumber))
    {
        maxNumber = MaxNumber(maxNumber, newNumber);
        Console.WriteLine("Şimdiye kadar girilen en yüksek sayı -> " + maxNumber);
    }
    else
    {
        Console.WriteLine("Lütfen bir sayı giriniz");
    }  
}

Console.WriteLine("Girdiğiniz en yüksek sayı -> " + maxNumber);

static double MaxNumber(double maxNumber, double newNumber) // Burada girilen değerlerlerin karşılaştırılıp yüksek olanın geriye döndüğü metodu tanımlıyorum.
{
    if (newNumber >= maxNumber)
        return newNumber;
    else
        return maxNumber;
}
*/

// 13. Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
/*
Console.WriteLine("1. metni giriniz:");
string metin1 = Console.ReadLine();

Console.WriteLine("2. metni giriniz:");
string metin2 = Console.ReadLine();

YerDegistirme(metin1, metin2);

static void YerDegistirme(string metin1, string metin2)
{
    string yerDegistir = ""; // Yer değiştirme işlemi için boş bir değer tanımlıyorum.

    yerDegistir = metin2;
    metin2 = metin1;
    metin1 = yerDegistir;
    
    Console.WriteLine("Metin 1'in değeri: " + metin1);
    Console.WriteLine("Metin 2'nin değeri: " + metin2);
}
*/

// 14. Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
/*
Console.Write("Lütfen bir sayı giriniz: ");
int sayı = Convert.ToInt32(Console.ReadLine());
bool sonuc = IsEven(sayı);

if (sonuc)
    Console.WriteLine("Sayı çifttir.");
else
    Console.WriteLine("Sayı tektir.");
static bool IsEven(int sayı) // True ya da false dönen metodu tanımlıyorum.
{
    return sayı % 2 == 0;
}
*/

// 15. Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
/*
Console.Write("Lütfen hız değerini giriniz: ");
double hız = Convert.ToDouble(Console.ReadLine());

Console.Write("Lütfen zaman değerini giriniz: ");
double zaman = Convert.ToDouble(Console.ReadLine());

double gidilenYol = GidilenYol(hız, zaman);
Console.WriteLine("Gidilen yol: " + gidilenYol);

static double GidilenYol(double hız, double zaman) // Metodu burada tanımlıyorum.
{
    return hız * zaman;
}
*/

// 16. Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
/*
Console.Write("Lütfen yarıçap değerini giriniz: ");
double yarıcap = Convert.ToDouble(Console.ReadLine());

double daireAlan = DaireAlan(yarıcap);
Console.WriteLine("Yarıçap değeri verilen dairenin alanı: " + daireAlan);

static double DaireAlan(double yarıcap)
{
    double pisayısı = 3.14;
    return pisayısı * (yarıcap * yarıcap);
}
*/

// 17. "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
/*
string originalMetin = "Zaman bir GeRi SayIm";
string lowMetin = originalMetin.ToLower();
string highMetin = originalMetin.ToUpper();

Console.WriteLine("Metnin küçük harflerle yazılmış hali -> " + lowMetin);
Console.WriteLine("Metnin büyük harflerle yazılmı hali -> " + highMetin);
*/

// 18. "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
/*
string text = "    Selamlar   ";
string trimmedText = text.Trim();

Console.WriteLine("Metnin trimlendikten sonraki hali -> '" + trimmedText + "'");
*/