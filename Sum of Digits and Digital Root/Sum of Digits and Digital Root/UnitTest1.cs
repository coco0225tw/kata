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
    
    [Test]
    public static void Input_has_3_digits()
    {
        Assert.That(Number.DigitalRoot(123), Is.EqualTo(6));
    }
    
    [Test]
    public static void Input_has_3_digits_and_should_do_recursion_multiple_times()
    {
        Assert.That(Number.DigitalRoot(195), Is.EqualTo(6));
    }
    
    [Test]
    public static void Input_has_5_digits_and_should_do_recursion_multiple_times()
    {
        Assert.That(Number.DigitalRoot(167346), Is.EqualTo(9));
    }
    
    [Test]
    public static void Input_has_12_digits_and_should_do_recursion_multiple_times()
    {
        Assert.That(Number.DigitalRoot(999999999999), Is.EqualTo(9));
    }
}