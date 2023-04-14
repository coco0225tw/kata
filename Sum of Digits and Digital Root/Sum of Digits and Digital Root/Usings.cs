global using NUnit.Framework;
using System.Collections;
using System;
public class Number
{
    public static int DigitalRoot(long n)
    {
        while (true)
        {
            if (n < 10) return (int)n; //cast

            var sum = 0;
            while (n != 0)
            {
                sum = (int)(sum + n % 10); //除以10得到的餘數 //cast
                n /= 10; //除以10得到的整數
            }

            n = sum;
        }
    }
}