namespace FindTheOddInt;

public class Tests
{
    
    [Test]
    public void Test1()
    {

        Assert.That(FindTheOddInt.find_it ( new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }), Is.EqualTo(5));
        
    }
    [Test]
    public void Test2()
    {

        Assert.That(FindTheOddInt.find_it ( new[] { 7 }), Is.EqualTo(7));
        
    }
    [Test]
    public void Test3()
    {

        Assert.That(FindTheOddInt.find_it ( new[] { 0 }), Is.EqualTo(0));
        
    }
    [Test]
    public void Test4()
    {

        Assert.That(FindTheOddInt.find_it ( new[] { 1,1,2 }), Is.EqualTo(2));
        
    }
    [Test]
    public void Test5()
    {

        Assert.That(FindTheOddInt.find_it ( new[] {0,1,0,1,0 }), Is.EqualTo(0));
        
    }
}