global using NUnit.Framework;
public static class Kata
{
    public static string Likes(string[] name)
    {
        var s = HandleSingularOrPlural(name);
        
        
        return s;
    }
    
    private static string HandleSingularOrPlural(string[] name)
    {
        var singularOrPlural = name.Length <= 1 ? "" : "s";
        var str = $"like{singularOrPlural} it.";
        return str;
    }
}