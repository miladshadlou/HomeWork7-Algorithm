using System.Text;

namespace HomeWork7;

public static class BinaryConverter
{
    public static string ToBinary(int n)
    {
        if (n == 0) return "0";

        long value = Math.Abs((long)n);
        var sb = new StringBuilder();

        while (value > 0)
        {
            sb.Append(value % 2);
            value /= 2;
        }

        char[] bits = sb.ToString().ToCharArray();
        Array.Reverse(bits);

        string result = new string(bits);

        return n < 0 ? "-" + result : result;
    }
}
