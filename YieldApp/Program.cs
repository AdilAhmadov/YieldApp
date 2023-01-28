// See https://aka.ms/new-console-template for more information
using YieldApp;

Console.WriteLine("Application Start\n");

foreach (var item in SeedData.GetPeople().Take(3).ToList())
{
    Console.WriteLine(item.ToString());
}

var primeNumbers = Generators.GetPrimeNumbers().Take(10);

foreach (var prime in primeNumbers)
{
    Console.WriteLine(prime);
}

Console.WriteLine("\nApplication End");
Console.Read();