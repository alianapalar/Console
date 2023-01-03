//int a = 2;
//int b = 3;
//Console.WriteLine(a + b);

//int sonuc = Topla(a, b);
//Console.WriteLine(sonuc);

//Metotlar ornek = new Metotlar();
//ornek.EkranaYazdir(Convert.ToString(sonuc));

//int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
//ornek.EkranaYazdir(Convert.ToString(sonuc2));
//ornek.EkranaYazdir(Convert.ToString(a + b));

//static int Topla(int deger1,int deger2)
//{
//    return(deger1+ deger2); 
//}


//class Metotlar 
//{
//    public void EkranaYazdir(string veri) 
//    {
//        Console.WriteLine(veri);
//    }
//    public int ArttirVeTopla(ref int deger1, ref int deger2) 
//    {
//        deger1 += 1;
//        deger2 += 1;
//        return deger1+ deger2;
//    }
//}

// out parametreler
string sayi = "999";
bool sonuc = int.TryParse(sayi, out int outSayi);
if (sonuc) 
{
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}
else 
{
    Console.WriteLine("Başarısız!");
}
Metotlar instance= new Metotlar();
instance.Topla(4, 5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

//Metot aşırı yükleme-overloading

int ifade = 999;
instance.EkranaYazdir(ifade);
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir("Ali", "Anapalar");

//metot imzası+parametre sayısı+parametre



class Metotlar 
{
    public void Topla(int a,int b,out int toplam) 
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri) 
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1,string veri2)
    {
        Console.WriteLine(veri1+veri2);
    }

}
