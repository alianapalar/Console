






enum Days 
{
    Monday=1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

enum WeatherForecast 
{
    Cold=5,
    Normal=10,
    Hot=25,
    SoHot=30
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Sunday);
        Console.WriteLine((int)Days.Monday);

        int temperature = 32;
        if (temperature <= (int)WeatherForecast.Normal) 
        {
            Console.WriteLine("Dışarıya çıkmak için biraz daha havanın ısınmasını bekle");
        }
        else if (temperature >= (int)WeatherForecast.Hot) 
        {
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
        }
        else if (temperature >= (int)WeatherForecast.Normal && temperature < (int)WeatherForecast.SoHot) 
        {
            Console.WriteLine("Hadi dışarıya");
        }
    }
}