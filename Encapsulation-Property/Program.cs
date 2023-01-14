
class Ogrenci 
{
    private string _name;
    private string _surname;
    private int _no;
    private int _sinif;
    public Ogrenci() { }

    public Ogrenci(string name, string surname, int no, int sinif)
    {
        Name = name;
        Surname = surname;
        No = no;
        Sinif = sinif;
    }

    public string Name 
    {
        get { return _name; }
        set { _name = value; } 
    }
    public string Surname { get => _surname; set => _surname = value; }
    public int No { get => _no; set => _no = value; }
    public int Sinif { get => _sinif;
        set
        {
            if (value < 1) 
            {
                Console.WriteLine("Sınıf En az 1 olabilir");
                _sinif = 1;
            }
            else 
            {
                _sinif = value;
            }
        }
    }

    public void OgrenciBilgileriniGetir() 
    {
        Console.WriteLine("Öğrencinin adı: {0}", Name);
        Console.WriteLine("Öğrencinin soyadı: {0}", Surname);
        Console.WriteLine("Öğrencinin numarası: {0}", No);
        Console.WriteLine("Öğrencinin sınıfı: {0}", Sinif);
    }
    public void SinifAtlat() 
    {
        Sinif = Sinif + 1;
    }
    public void SinifDusur() 
    {
        Sinif = Sinif - 1;
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Name = "Kamile";
        ogrenci.Surname = "Fırsat";
        ogrenci.No = 237232;
        ogrenci.Sinif = 3;
        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgileriniGetir();

        Ogrenci ogrenci1=new Ogrenci("Ferit","Katı",328832,1);
        ogrenci1.SinifDusur();
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileriniGetir();



    }
}
