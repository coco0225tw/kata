using NUnit.Framework;

namespace FindTheParityOutlier;

public class Tests
{
    
    [Test]
    public void return_odd_int()
    {
        int[] input = {2,6,8,-10,3}; 
        Assert.That(Kata.Find(input), Is.EqualTo(3));
    }
    [Test]
    public void return_even_int()
    {
        int[] input = {5,1,8,-10,3}; 
        Assert.That(Kata.Find(input), Is.EqualTo(8));
    }
    
    [Test]
    public static void test_intMaxValue_and_0()
    {
        int[] input = {0, int.MaxValue, 1}; 
        Assert.That(Kata.Find(input), Is.EqualTo(0));
    }
}