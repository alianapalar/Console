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
//string sayi = "999";
//bool sonuc = int.TryParse(sayi, out int outSayi);
//if (sonuc) 
//{
//    Console.WriteLine("Başarılı!");
//    Console.WriteLine(outSayi);
//}
//else 
//{
//    Console.WriteLine("Başarısız!");
//}
//Metotlar instance= new Metotlar();
//instance.Topla(4, 5, out int toplamSonucu);
//Console.WriteLine(toplamSonucu);

////Metot aşırı yükleme-overloading

//int ifade = 999;
//instance.EkranaYazdir(ifade);
//instance.EkranaYazdir(Convert.ToString(ifade));
//instance.EkranaYazdir("Ali", "Anapalar");

////metot imzası+parametre sayısı+parametre



//class Metotlar 
//{
//    public void Topla(int a,int b,out int toplam) 
//    {
//        toplam = a + b;
//    }

//    public void EkranaYazdir(string veri) 
//    {
//        Console.WriteLine(veri);
//    }
//    public void EkranaYazdir(int veri)
//    {
//        Console.WriteLine(veri);
//    }
//    public void EkranaYazdir(string veri1,string veri2)
//    {
//        Console.WriteLine(veri1+veri2);
//    }

//}

//Recursive-Öz yinelemeli

using System.Reflection.Metadata;

int result = 1;
for(int i = 1; i < 5; i++)
{
    result*= 3;
    
}
Console.WriteLine(result);
Islemler instance = new();
Console.WriteLine(instance.Expo(3, 4));

//Extension Metotlar
string ifade = "Ali Anapalar";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc);

if (sonuc) 
{
    Console.WriteLine(ifade.RemoveWhiteSpaces());
}
Console.WriteLine(ifade.MakeUpperCase());
Console.WriteLine(ifade.MakeLowerCase());

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
dizi.SortArray();
dizi.EkranaYazdir();

int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber());
Console.WriteLine(ifade.GetFirstCharacter());


public class Islemler 
{
    public int Expo(int sayi,int us) 
    {
        if (us == 0) 
        {
            return 1;
        }
        else if (us == 1) 
        {
            return sayi;
        }
        else 
        {
            return Expo(sayi, us - 1) * sayi;
        }
        
    }
}

public static class Extension 
{
    public static bool CheckSpaces(this string param) 
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(' ');
        return string.Join(" ", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArray(this int[] param) 
    {
        Array.Sort(param);
        return param;
    }
    public static void EkranaYazdir(this int[] param) 
    {
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
    }
    public static bool IsEvenNumber(this int param) 
    {
        return param % 2 == 0;
    }  
    public static string GetFirstCharacter(this string param) 
    {
        return param.Substring(0, 1);
    }

}