//While
//1 den başlayarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp ekrana yazdıran program

Console.WriteLine("Bir sayı giriniz");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi) 
{
    toplam += sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);
//  'a' dan 'z'ye kadar olan tüm harfleri console a yazdır.
char character = 'a';

while (character < 'z') 
{
    Console.WriteLine(character);
    character++;
}

Console.Write("***** ForEach *****");
string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}

