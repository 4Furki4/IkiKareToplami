// See https://aka.ms/new-console-template for more information




Console.WriteLine("Merhabalar, gireceğiniz iki integer sayının kareleri toplanıp ekrana yazdırılacak.");
int durum=1;
while(durum==1)
{
    TumIslemiYap();
    durum=uygulamaDurumu(); // Problemi bir kere çalıştırdıktan sonra konsoldan alınan girdiye göre uygulamaya devam edeceğiz veya etmeyeceğiz.
}

static void SayilariAl(out int ilkSayi, out int ikinciSayi) // Konsoldan 2 tane sayi alacağız ve bunları out keyword'üyle yeni değişkenlere atayıp kullanacağız.
{
    Console.Write("Lütfen ilk sayıyı giriniz: ");
    ilkSayi=int.Parse(Console.ReadLine());
    Console.Write("Lütfen ikinci sayıyı giriniz: ");
    ikinciSayi=int.Parse(Console.ReadLine());
}
static double KareleriniTopla(int sayi1, int sayi2) 
{
    return Math.Pow(sayi1,2) + Math.Pow(sayi2,2);
}

static void TumIslemiYap() //SayılariAl metodunu çalıştırıp elde ettiğimiz sayilarla KareleriniTopla metodunu çalıştıran ve sonucu ekrana yazdıran metot.
{
    double sonuc;
    try 
    { // Sayı yerine harf girilirse yakalayacağımız try-catch yapısı.
        SayilariAl(out int ilkSayi, out int ikinciSayi);
        sonuc= KareleriniTopla(ilkSayi, ikinciSayi);
        Console.WriteLine($"Girmiş olduğunuz iki sayının karelerinin toplamı {sonuc} olarak hesaplandı");
    }
    catch
    {
        Console.WriteLine("Lütfen girdiğiniz değerlerin integer olduğundan emin olunuz.");
        TumIslemiYap(); // doğru sayıları girene kadar inatla tekrar tekrar sayi istemek için metodu kendi içinde tekrardan çağırıyoruz.

    }
    
}


static int uygulamaDurumu() // Uygulamadan çıkılmak istendiğinde uygulamayı kapatır veya yeniden işlemimizi yapmayı sağlar.
{
    Console.Write("Uygulamadan çıkmak için 0, devam etmek için 1 yazınız: ");
    int akibet;
    try
    {
        akibet=int.Parse(Console.ReadLine());
        
    }
    catch
    {
        akibet = uygulamaDurumu();
        
    }
    return akibet;
    
}