namespace DismantleVowelTrolls;

public class DismantleVowelTrolls
{
    public static string Disemvowel(string str)
    {
        string data = "aeiouAEIOU";
        List<char> charsToRemove = new List<char>();
        charsToRemove.AddRange(data);
      
        charsToRemove.ForEach(c => str = str.Replace(c.ToString(), String.Empty));
     
        return str;
    }
}