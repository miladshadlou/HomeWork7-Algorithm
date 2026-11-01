namespace HomeWork7;

public static class DigitSum
{
    public static int DigitsSum(long n)
    {
        int sum = 0;

        while (n != 0)
        {
            sum += (int)Math.Abs(n % 10);
            n /= 10;
        }

        return sum;
    }
}
