namespace OrderedCountofCharacters;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("abracadabra"), Is.EqualTo(new Dictionary<char, int>()
            {
                { 'a', 5 },
                { 'b', 2 },
                { 'r', 2 },
                { 'c', 1 },
                { 'd', 1 }
            }));
    }

    [Test]
    public void TestCase2()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("everything"), Is.EqualTo(new Dictionary<char, int>()
            {
                { 'e', 2 },
                { 'v', 1 },
                { 'r', 1 },
                { 'y', 1 },
                { 't', 1 },
                { 'h', 1 },
                { 'i', 1 },
                { 'n', 1 },
                { 'g', 1 }

            }));
    }

    [Test]
    public void TestCase3()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("capybara"), Is.EqualTo(new Dictionary<char, int>()
            {
                { 'c', 1 },
                { 'a', 3 },
                { 'p', 1 },
                { 'y', 1 },
                { 'b', 1 },
                { 'r', 1 }
            }));
    }
}

