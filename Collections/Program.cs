//Soru 1 Koleksiyon
List<int> primeNumbers = new List<int>();
List<int> nonPrimeNumbers = new List<int>();

for (int i = 0; i < 20; i++)
{
    int num = 0;
    bool isPrime = true;

    // Negative or non-numeric input check
    while (num <= 0)
    {
        Console.Write("Enter a positive number: ");
        if (int.TryParse(Console.ReadLine(), out num) && num > 0)
        {
            //continue
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            continue;
        }
    }

    // Prime number check
    if (num == 1)
    {
        isPrime = false;
    }
    else
    {
        for (int j = 2; j <= num / 2; j++)
        {
            if (num % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    // Adding number to appropriate list
    if (isPrime)
    {
        primeNumbers.Add(num);
    }
    else
    {
        nonPrimeNumbers.Add(num);
    }
}

// Sorting and printing the lists
primeNumbers.Sort();
primeNumbers.Reverse();
nonPrimeNumbers.Sort();
nonPrimeNumbers.Reverse();
Console.WriteLine("Prime numbers: " + string.Join(",", primeNumbers));
Console.WriteLine("Non-prime numbers: " + string.Join(",", nonPrimeNumbers));

// Printing the number of elements and average of each list
int primeNumbersCount = primeNumbers.Count;
int nonPrimeNumbersCount = nonPrimeNumbers.Count;
double primeNumbersAvg = primeNumbers.Average();
double nonPrimeNumbersAvg = nonPrimeNumbers.Average();
Console.WriteLine("Prime numbers count: " + primeNumbersCount + ", average: " + primeNumbersAvg);
Console.WriteLine("Non-prime numbers count: " + nonPrimeNumbersCount + ", average: " + nonPrimeNumbersAvg);
// soru 2 koleksiyon