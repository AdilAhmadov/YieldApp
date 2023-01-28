namespace YieldApp
{
    public class Generators
    {
        public static IEnumerable<int> GetPrimeNumbers()
        {
            int counter = 1;
            while (true)
            {
                if (IsPrimeNumber(counter))
                {
                    if (counter!=1)
                        yield return counter;
                }
                counter++;
            }
        }
        private static bool IsPrimeNumber(int number)
        {
            bool output = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    output = false;
                    break;
                }
            }
            return output;
        }
        public static IEnumerable<int> Get()
        {
            return GetPrimeNumbers();
        }
    }
}
