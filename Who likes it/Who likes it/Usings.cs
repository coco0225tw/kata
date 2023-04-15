global using NUnit.Framework;
public static class Kata
{
    public static string Likes(string[] name)
    {
        var s = HandleSingularOrPlural(name);
        var names = HandleDisplayName(name);
        
        return $"{names} {s}";
    }
    
    private static string HandleSingularOrPlural(string[] name)
    {
        var singularOrPlural = name.Length <= 1 ? "s" : "";
        var str = $"like{singularOrPlural} this";
        return str;
    }
    private static string HandleDisplayName(string[] name)
    {
        return name.Length switch
        {
            0 => "no one",
            1 => name[0],
            2 => $"{name[0]} and {name[1]}",
            3 => $"{name[0]}, {name[1]} and {name[2]}",
            _ => $"{name[0]}, {name[1]} and {name.Length - 2} others"
        };
    }
}