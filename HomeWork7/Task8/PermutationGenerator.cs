namespace HomeWork7;

public static class PermutationGenerator
{
    public static List<string> Permutations(string s)
    {
        var result = new List<string>();
        if (string.IsNullOrEmpty(s)) 
        throw new ArgumentNullException();

        char[] chars = s.ToCharArray();
        Array.Sort(chars);                       // needed for the duplicate-skip 
        var used = new bool[chars.Length];
        var current = new char[chars.Length];

        void Backtrack(int position)
        {
            if (position == chars.Length)
            {
                result.Add(new string(current));
                return;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (used[i]) continue;
                if (i > 0 && chars[i] == chars[i - 1] && !used[i - 1]) continue; // skip duplicates

                used[i] = true;
                current[position] = chars[i];
                Backtrack(position + 1);
                used[i] = false;
            }
        }

        Backtrack(0);
        return result;
    }
}
