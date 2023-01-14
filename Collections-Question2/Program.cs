int[] numbers = new int[20];
for (int i = 0; i < 20; i++)
{
    Console.Write("Enter a number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] largest3 = numbers.OrderByDescending(x => x).Take(3).ToArray();
int[] smallest3 = numbers.OrderBy(x => x).Take(3).ToArray();
double largestAvg = largest3.Average();
double smallestAvg = smallest3.Average();
double totalAvg = (largestAvg + smallestAvg) / 2;

Console.WriteLine("Largest 3 numbers: " + string.Join(", ", largest3));
Console.WriteLine("Smallest 3 numbers: " + string.Join(", ", smallest3));
Console.WriteLine("Average of largest 3 numbers: " + largestAvg);
Console.WriteLine("Average of smallest 3 numbers: " + smallestAvg);
Console.WriteLine("Total average: " + totalAvg);