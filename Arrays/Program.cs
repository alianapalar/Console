
//Dizi Tanımlama
//string[]renkler=new string[5];
//string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

//int[] dizi;
//dizi= new int[5];
////Dizilere Değer Atama
//renkler[0] = "Mavi";
//dizi[3] = 10;

//Console.WriteLine(hayvanlar[1]);
//Console.WriteLine(dizi[3]);
//Console.WriteLine(renkler[0]);

////Döngülerle dizi kullanımı
////Klavyeden girilen n tane sayının ortalamasını hesaplayan program
//Console.Write("Lütfen dizinin eleman sayısını giriniz.");
//int diziUzunlugu = int.Parse(Console.ReadLine());
//int[] sayiDizisi = new int[diziUzunlugu];

//for(int i = 0; i < diziUzunlugu; i++)
//{
//    Console.Write("Lütfen {0}.sayısı giriniz", i + 1);
//    sayiDizisi[i] = int.Parse(Console.ReadLine());
//}
//int toplam = 0;
//foreach (var sayi in sayiDizisi)
//{
//    toplam += sayi;
//}
//Console.WriteLine(toplam/diziUzunlugu);

//Arrays Methodları
int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

Console.WriteLine("-------Sırasız Dizi------");
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------Sıralı Dizi------");
Array.Sort(sayiDizisi);

foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}


//Clear
Console.WriteLine("-------Array Clear------");
// sayiDizisi elemanlarını kullanarak 4. indexten (5. eleman) itibaren 3 tane elemanı 0lar

Array.Clear(sayiDizisi, 4, 3);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}

//Reverse
Console.WriteLine("-------Array Reverse------");
// dizinin sırasını değiştirir  başı sona sonu başa getirir
Array.Reverse(sayiDizisi);
foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}


//İndexOf
Console.WriteLine("-------Array IndexOf------");
Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


//Resize
Console.WriteLine("-------Array Resize------");
// sayiDizisi boyutu 12 elemana çıkarıldı
Array.Resize<int>(ref sayiDizisi, 12);
// sayiDizisi 9.cu elemanı 99 olarak atandı  boş elemanalar 0 olarak atandı
sayiDizisi[8] = 99;

foreach (var item in sayiDizisi)
{
    Console.WriteLine(item);
}
