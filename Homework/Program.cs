





using System;

sorular soru = new sorular();
//soru.ciftYazdir();

//soru.tamBolen();
//soru.kelimeSay();
//soru.kelimeYaz();

//}
class sorular
{
    //1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
    //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    public void ciftYazdir()
    {
        Console.WriteLine("Lütfen pozitif bir sayı giriniz (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // kullanıcıdan n adet sayı al
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Lütfen {i + 1}. sayıyı giriniz: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // çift sayıları yazdır
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    //2)Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    public void tamBolen()
    {
       
        int[] sayi = new int[2];
        for (int i = 0; i < 2; i++)
        {
            Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
            sayi[i] = Convert.ToInt32(Console.ReadLine());
        }
        int a = sayi[0];
        int[] rakam = new int[a];
        Console.WriteLine("Klavyeden" + sayi[0] + "adet sayı girin.");
        for (int i = 0; i < rakam.Length; i++)
        {
            Console.WriteLine("Klavyeden" + " " + (i + 1) + ". sayı girin.");
            rakam[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < rakam.Length; i++)
        {
            if (rakam[i] % sayi[1] == 0 || rakam[i] == sayi[1])
            {
                Console.WriteLine(rakam[i]);
            }
        }
    }
    //3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    public void kelimeYaz()
    {
        
        Console.WriteLine("Lütfen pozitif bir sayı giriniz (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // kullanıcıdan n adet kelime al
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Lütfen {i + 1}. kelimeyi giriniz: ");
            words[i] = Console.ReadLine();
        }

        // kelimeleri sondan başa doğru yazdır
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }

    }
    //4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın
    public void kelimeSay()
    {
        //Console.WriteLine("Bir Cümle Yazınız");
        //string cumle = Console.ReadLine();
        //string[] kelimeler = cumle.Split(' ');
        //foreach (var item in kelimeler)
        //{
        //    Console.WriteLine(item);
        //}
        Console.WriteLine("Lütfen bir cümle giriniz: ");
        string input = Console.ReadLine();

        // kelime ve harf sayısını hesapla
        string[] words = input.Split(' ');
        int wordCount = words.Length;
        int letterCount = input.Length;

        // sonuçları ekrana yazdır
        Console.WriteLine($"Cümlenizde toplam {wordCount} kelime ve {letterCount} harf var.");
    }
}
