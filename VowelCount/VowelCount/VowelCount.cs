namespace VowelCount;

public class VowelCount
{
    public static int GetVowelCount(string str)
    {
        var count = 0;
        foreach (var w in str)
        {
            if(w == 'a' |
               w == 'e' |
               w == 'i' |
               w == 'o' |
               w == 'u' 
              ) count++;
        }

        return count;
    }
}