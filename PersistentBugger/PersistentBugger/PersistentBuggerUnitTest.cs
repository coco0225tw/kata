using NUnit.Framework;

namespace PersistentBugger;

public class Tests
{
    [Test]
    public void multiple_0_times()
    {
        Assert.That(Persist.Persistence(4), Is.EqualTo(0));
    }

    [Test]
    public void multiple_2_times()
    {
        Assert.That(Persist.Persistence(25), Is.EqualTo(2));
    }
}