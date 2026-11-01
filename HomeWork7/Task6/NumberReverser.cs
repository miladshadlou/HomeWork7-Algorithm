namespace HomeWork7
{
    public static class NumberReverser
    {
        public static long ReverseNumber(int n)
        {
            long value = Math.Abs((long)n);
            long reversed = 0;
            while (value > 0)
            {
                reversed = reversed * 10 + value % 10;
                value /= 10;
            }
            return n < 0 ? -reversed : reversed;
        }
    }
}
