class Calisan 
{
    private static int _totalEmployee;

    public static int TotalEmployee { get => _totalEmployee; set => _totalEmployee = value; }

    private string _name;
    private string _surname;
    private string _departmant;
    
    static Calisan() 
    {
        _totalEmployee= 0;
    }
    public Calisan(string name,string surname,string departmant) 
    {
        _name= name;
        _surname= surname;
        _departmant= departmant;
        _totalEmployee++;
    }
}
static class Islemler
{
    public static long Topla (int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}


class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Çalışan sayısı: {0}", Calisan.TotalEmployee);

        Calisan calisan = new Calisan("Kerim", "Severim", "İK");
        Console.WriteLine("Çalışan sayısı: {0}", Calisan.TotalEmployee);

        Calisan calisan1 = new Calisan("Fırtına", "Esti", "Arge");
        Calisan calisan2 = new Calisan("Lodos", "Esmedi", "IT");
        Console.WriteLine("Çalışan sayısı: {0}", Calisan.TotalEmployee);


        Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
        Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(400, 50));

    }
}
