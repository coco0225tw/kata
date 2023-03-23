namespace DismantleVowelTrolls;

public class DismantleVowelTrolls
{
    public static string Disemvowel(string str)
    {
        var charsToRemove = new List<char>() {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O','U'};
        charsToRemove.ForEach(c => str = str.Replace(c.ToString(), String.Empty));
     
        return str;
    }
}