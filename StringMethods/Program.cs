// Soru 1: Exception  String-to Integer
string S = Console.ReadLine();
try
{
    var i = int.Parse(S);
    Console.Write(i);
}
catch
{
    Console.Write("Bad String");
}
//Soru 2: LetsReview
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++) 
{
    string s = Console.ReadLine();
    LetsReview(s);
}


static void LetsReview(string s)
{
    string evenStr = "";
    string oddStr = "";

    for(int i = 0; i < s.Length; i++) 
    {
        if (i % 2 == 0)
        {
            evenStr += s[i];
        }
        else
        {
            oddStr += s[i];
        }
    }
    Console.WriteLine($"{evenStr} {oddStr}");
}
