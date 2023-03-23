namespace OrderedCountofCharacters;

public class OrderedCountofCharacters
{
    public static Dictionary<char, int> OrderedCount(string input)
    {
        Dictionary<char, int> counts = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
            if (counts.ContainsKey(input[i]))
                counts[input[i]]++;
            else
                counts.Add(input[i], 1);
        return counts
    ;
}
}