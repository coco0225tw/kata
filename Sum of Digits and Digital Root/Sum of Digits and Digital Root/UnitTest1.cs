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
    
    [Test]
    public static void Input_has_2_digits()
    {
        Assert.That(Number.DigitalRoot(16), Is.EqualTo(7));
    }
    
}