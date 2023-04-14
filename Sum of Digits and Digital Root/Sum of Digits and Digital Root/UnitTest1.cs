namespace Sum_of_Digits_and_Digital_Root;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public static void Input_is_0()
    {
        Assert.That(Number.DigitalRoot(0), Is.EqualTo(0));
    }
    
}