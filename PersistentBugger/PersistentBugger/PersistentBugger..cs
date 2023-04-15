namespace PersistentBugger;

public class Persist 
{
    public static int Persistence(long n)
    {
        while (true)
        {
            // your code
            var times = 0; 
            var multiply = 1;

            while (true)
            { 
                if (n < 10) return (int)times; //cast
                while (n != 0) 
                {
                    multiply = (int)(multiply * n % 10); //除以10得到的餘數 //cast
                    n /= 10; //除以10得到的整數
                    times++; 
                }
               
                
                if(multiply/10==0)
                {
                    return times;
                }
                else 
                {
                    n = multiply;
                    multiply = 1;
                }
            }
        }
    }
}