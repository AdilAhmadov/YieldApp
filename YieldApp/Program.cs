// See https://aka.ms/new-console-template for more information
using YieldApp;

Console.WriteLine("Application Start\n");

foreach (var item in SeedData.GetPeople().Take(3).ToList())
{
    Console.WriteLine(item.ToString());
}

var primeNumbers = Generators.GetPrimeNumbers();

var iterator = primeNumbers.GetEnumerator();

for (int i = 0; i < 10; i++)
{
    if (iterator.MoveNext())
        Console.WriteLine(iterator.Current);
    else break;
}

//Console.WriteLine();
//foreach (var prime in primeNumbers)
//{
//    Console.WriteLine(prime);
//}

Console.WriteLine("Waiting For User Inputs");
Console.ReadLine();

for (int i = 0; i < 10; i++)
{
    if (iterator.MoveNext())
        Console.WriteLine(iterator.Current);
    else break;
}
//primeNumbers = Generators.GetPrimeNumbers().Take(15);

//foreach (var prime in primeNumbers)
//{
//    Console.WriteLine(prime);
//}

Console.WriteLine("\nApplication End");
Console.Read();