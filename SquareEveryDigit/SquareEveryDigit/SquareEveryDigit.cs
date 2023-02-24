namespace SquareEveryDigit;

public class SquareEveryDigit
{
    public static int SquareDigits(int n)
    {
        if (n == 0) return 0;
        var digits = n.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
        var ans = 0;
      
        foreach(var d in digits) {
            ans = int.Parse(ans.ToString() + (d * d).ToString());
        }
        return ans;

    }
}