namespace VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var vowelCount = 0;

        int index;
        for (index = 0; index < str.Length; index++)
        {
            var n = str[index];
            if (
                n == 'a' |
                n == 'e' |
                n == 'i' |
                n == 'o' |
                n == 'u'
            ) vowelCount++;
        }

        return vowelCount;
    }
}