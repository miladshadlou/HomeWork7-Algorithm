namespace HomeWork7;

public static class PrimeNumber
{
    public static bool IsPrime(int n)
    {
        long number = Math.Abs((long)n);

        if (number < 2)
            return false;

        if (number % 2 == 0)
            return number == 2;

        for (long i = 3; i <= number / i; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
