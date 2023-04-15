namespace Who_likes_it;

public static class Kata
{
    public static string Likes(string[] name)
    {
        var filteredNames = HandleInvalidInput(name);
        var s = HandleSingularOrPlural(filteredNames);
        var names = HandleDisplayName(filteredNames);
        
        return $"{names} {s}";
    }
    
    private static string HandleSingularOrPlural(IReadOnlyCollection<string> name)
    {
        var singularOrPlural = name.Count <= 1 ? "s" : "";
        var str = $"like{singularOrPlural} this";
        return str;
    }
    private static string HandleDisplayName(IReadOnlyList<string> name)
    {
        return name.Count switch
        {
            0 => "no one",
            1 => name[0],
            2 => $"{name[0]} and {name[1]}",
            3 => $"{name[0]}, {name[1]} and {name[2]}",
            _ => $"{name[0]}, {name[1]} and {name.Count - 2} others"
        };
    }
    
    private static string[] HandleInvalidInput(string[] name)
    {
        var filtered = Array.FindAll(name, e => !string.IsNullOrWhiteSpace(e));
        return filtered;
    }
}