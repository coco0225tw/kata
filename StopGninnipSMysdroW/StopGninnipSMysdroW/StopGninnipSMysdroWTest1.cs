namespace StopGninnipSMysdroW;

public class Tests
{
    [Test]
    public static void Test1()
    {
        Assert.That(StopGninnipSMysdroW.SpinWords("Welcome"), Is.EqualTo("emocleW"));
    }
  
    [Test]
    public static void Test2()
    {  
        Assert.That(StopGninnipSMysdroW.SpinWords("Hey fellow warriors"), Is.EqualTo("Hey wollef sroirraw"));
    }
  
    [Test]
    public static void Test3()
    {
        Assert.That(StopGninnipSMysdroW.SpinWords("This is a test"), Is.EqualTo("This is a test"));
    }
  
    [Test]
    public static void Test4()
    {
        Assert.That(StopGninnipSMysdroW.SpinWords("This is another test"), Is.EqualTo("This is rehtona test"));
    }
  
    [Test]
    public static void Test5()
    {
        Assert.That(StopGninnipSMysdroW.SpinWords("You are almost to the last test"), Is.EqualTo("You are tsomla to the last test"));
    }
  
    [Test]
    public static void Test6()
    {
        Assert.That(StopGninnipSMysdroW.SpinWords("Just kidding there is still one more"), Is.EqualTo("Just gniddik ereht is llits one more"));
    }
}