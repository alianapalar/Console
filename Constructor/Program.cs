
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Calisan1 ****");
        Calisan calisan1 = new Calisan("Ayşe", "Korkmaz", 2323285, "Arge");
        calisan1.CalisanBilgileri();
        Console.WriteLine("**** Calisan2 **** ");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Kamil";
        calisan2.Soyad = "Kükrer";
        calisan2.No = 72737273;
        calisan2.Departman = "İnsan Kaynakları";
        calisan2.CalisanBilgileri();
       Console.WriteLine("**** Calisan3 ****");
       Calisan calisan3=new Calisan("Fikriye","Farkında");
       calisan3.CalisanBilgileri();
    }
}


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan() { }

    public Calisan(string ad,string soyad) 
    {
        this.Ad = ad; 
        this.Soyad = soyad;
    }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın adı {0}", Ad);
        Console.WriteLine("Çalışanın soyadı {0}", Soyad);
        Console.WriteLine("Çalışanın numarası {0}", No);
        Console.WriteLine("Çalışanın departmanı {0}", Departman);
    }
}