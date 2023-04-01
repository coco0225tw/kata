namespace Array.diff;

public class Array
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        var result = a.Where(i => !b.Contains(i)).ToArray();
        return result;
    }
}