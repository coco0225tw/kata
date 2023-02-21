namespace VowelCount;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(VowelCount.GetVowelCount("abracadabra"), Is.EqualTo(5), "Something wrong");
    }
    [Test]
    public void TestCase2()
    {
        Assert.AreEqual(10,VowelCount.GetVowelCount("aeiouaeiou "), "Something wrong");
    }
    [Test]
    public void TestCase3()
    {
        Assert.That(VowelCount.GetVowelCount("abcdefg "),Is.EqualTo(2), "Something wrong");
    }

    [Test]
    public void TestCase4()
    {
        Assert.That(VowelCount.GetVowelCount("woigekonsw"), Is.EqualTo(4), "Something wrong");
    }

    [Test]
    public void TestCase5()
    {
        Assert.That(VowelCount.GetVowelCount("fefefefef"), Is.EqualTo(4), "Something wrong");
    }
}