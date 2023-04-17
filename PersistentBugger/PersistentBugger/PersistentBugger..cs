namespace PersistentBugger;

public abstract class Persist 
{
    public static int Persistence(long n)
    {
        var times = 0;
            long multiply = 1;
    
            if(n/10==0 || n < 0) return 0;

            while (true)
            {
                while (n != 0)
                {
                    multiply *= n % 10;
                    n /= 10;

                }

                times++;

                if (multiply / 10 == 0) return times;
                n = multiply;
                multiply = 1;
            }
    }
}