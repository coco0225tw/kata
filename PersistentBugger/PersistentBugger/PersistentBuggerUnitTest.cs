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
    
    [Test]
    public void multiple_3_times()
    {
        Assert.That(Persist.Persistence(39), Is.EqualTo(3));
    }

    [Test]
    public void multiple_4_times()
    {
        Assert.That(Persist.Persistence(999), Is.EqualTo(4));
    }

    [Test]
    public void when_input_is_0_should_multiply_0_time()
    {
        Assert.That(Persist.Persistence(999), Is.EqualTo(4));
    }
    
    [Test]
    public void when_input_is_negative_should_multiply_0_time()
    {
        Assert.That(Persist.Persistence(-10), Is.EqualTo(0));
    }
}