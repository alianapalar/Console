
//Soru 1:More Exceptions


using System.Globalization;


class Calculator 
{
    public int power(int n,int p) 
    {
        if (n < 0 || p < 0) 
        {
            throw new Exception("n and p should be non-negative");
        }

        return (int)Math.Pow(n, p);
    }
}
class Result {
    public static string timeConversion(string s)
    {
        var dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
        return $"{dt:HH:mm:ss}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator myCalculator = new Calculator();
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]);
            try
            {
                int ans = myCalculator.power(n, p);
                Console.WriteLine(ans);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
        // soru 2 : Time Conversion
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}





        