namespace FindTheParityOutlier;

public class Kata
{
    public static int Find(int[] integers)
    {
        var evenNum = integers.Where(integer => integer % 2 == 0 && integer >= 0).ToArray();
        var oddNum = integers.Where(integer => integer % 2 == 1 && integer >= 0);
        return evenNum.Length == 1 ? evenNum.First() : oddNum.First();
    }
}