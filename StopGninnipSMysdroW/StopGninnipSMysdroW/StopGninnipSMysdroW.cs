using System.Diagnostics;

namespace StopGninnipSMysdroW;

public class StopGninnipSMysdroW
{
    public static string SpinWords(string sentence)
    {
        var stringList = sentence.Split().ToList();
        stringList = stringList.
            Select (x => GetStringLengthBiggerThan5(x) ? ReversString(x): x).ToList ();
        return string.Join(" ", stringList);

    }

    private static bool GetStringLengthBiggerThan5(string words)
    {
        return words.Length >= 5;
    }

    private static string ReversString(string words)
    {
        var charArray = words.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}