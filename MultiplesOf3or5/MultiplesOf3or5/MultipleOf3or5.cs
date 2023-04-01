namespace MultiplesOf3or5;

public class MultipleOf3or5
{
    public static int Solution(int num)
    {
        //If the number is a multiple of both 3 and 5, only count it once.
        var resultList = new List<int>();
        for (var n = 1; n < num; n++)
        {
            if (n % 15 == 0)
            {
                resultList.Add(n);
            }
            else if(n % 3 == 0 || n % 5 == 0)
            {
                resultList.Add(n);
            }

        }
        
        var sum = resultList.Sum();
        return sum;
    }
}