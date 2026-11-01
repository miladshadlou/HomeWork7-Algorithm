namespace HomeWork7;

public class DuplicateChecker
{
    public static bool HasDuplicate(int[] a)
    {
        var seen = new HashSet<int>();
        foreach (int x in a)
        {
            if (!seen.Add(x))                    // Add returns false if already present
                return true;
        }
        return false;
    }
}
