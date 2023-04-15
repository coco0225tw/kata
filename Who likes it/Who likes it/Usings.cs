global using NUnit.Framework;
public static class Kata
{
    public static string Likes(string[] name)
    {
        var singularOrPlural = name.Length <= 1 ? "" : "s";
        var str = $"like{singularOrPlural} it.";
        return str;
    }
}