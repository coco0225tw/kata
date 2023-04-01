namespace MultiplesOf3or5;

public class Tests
{


    [Test]
    public void Test1()
    {
        Assert.That(MultipleOf3or5.Solution(10), Is.EqualTo(23));
    }
    [Test]
    public void Test2()
    {
        Assert.That(MultipleOf3or5.Solution(0), Is.EqualTo(0));
    }
    [Test]
    public void Test3()
    {
        Assert.That(MultipleOf3or5.Solution(30), Is.EqualTo(195));
    }
}