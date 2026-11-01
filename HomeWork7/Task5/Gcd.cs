namespace HomeWork7;

public static class Gcd
{
    public static long FindGcd(long a, long b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
            (a, b) = (b, a % b);
        return a;
    }

}
