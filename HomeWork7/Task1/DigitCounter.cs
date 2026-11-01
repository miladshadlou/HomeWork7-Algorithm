namespace HomeWork7;

public static class DigitCounter
{
   public static int CountDigits(long n)
{
    int count = 1;

    while (n >= 10 || n <= -10)
    {
        count++;
        n /= 10;
    }

    return count;
}
}
