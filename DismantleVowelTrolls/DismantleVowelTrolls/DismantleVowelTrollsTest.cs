namespace DismantleVowelTrolls;

public class Tests
{

    [Test]
    public void TestCase1()
    {
        Assert.That(DismantleVowelTrolls.Disemvowel("This website is for losers LOL!"), Is.EqualTo("Ths wbst s fr lsrs LL!"), "Something wrong");
    }
    
    [Test]
    public void TestCase2()
    {
        Assert.That(DismantleVowelTrolls.Disemvowel("Everything Everywhere All at Once"), Is.EqualTo("vrythng vrywhr ll t nc"), "Something wrong");
    }
    
    [Test]
    public void TestCase3()
    {
        Assert.That(DismantleVowelTrolls.Disemvowel("Crouching Tiger, Hidden Dragon"), Is.EqualTo("Crchng Tgr, Hddn Drgn"), "Something wrong");
    }
    
    [Test]
    public void TestCase4()
    {
        Assert.That(DismantleVowelTrolls.Disemvowel("Action/Adventure"), Is.EqualTo("ctn/dvntr"), "Something wrong");
    }
    
    [Test]
    public void TestCase5()
    {
        Assert.That(DismantleVowelTrolls.Disemvowel("About this movie"), Is.EqualTo("bt ths mv"), "Something wrong");
    }
}