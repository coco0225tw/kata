namespace SquareEveryDigit;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(SquareEveryDigit.SquareDigits(9119), Is.EqualTo(811181), "Something Wrong");
    }
    [Test]
    public void TestCase2()
    {
        Assert.That(SquareEveryDigit.SquareDigits(0), Is.EqualTo(0), "Something Wrong");
    }
    [Test]
    public void TestCase3()
    {
        Assert.That(SquareEveryDigit.SquareDigits(366), Is.EqualTo(93636), "Something Wrong");
    }

    [Test]
    public void TestCase4()
    {
        Assert.That(SquareEveryDigit.SquareDigits(103), Is.EqualTo(109), "Something Wrong");
    }

    [Test]
    public void TestCase5()
    {
        Assert.That(SquareEveryDigit.SquareDigits(5210), Is.EqualTo(25410), "Something Wrong");
    }
}