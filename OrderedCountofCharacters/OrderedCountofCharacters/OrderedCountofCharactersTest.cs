namespace OrderedCountofCharacters;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("abracadabra"), Is.EqualTo(new List<Tuple<char, int>>() {
                Tuple.Create('a', 5),
                Tuple.Create('b', 2),
                Tuple.Create('r', 2),
                Tuple.Create('c', 1),
                Tuple.Create('d', 1)
            }));
    }
    [Test]
    public void TestCase2()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("everything"), Is.EqualTo(new List<Tuple<char, int>>() {
                Tuple.Create('e', 2),
                Tuple.Create('v', 1),
                Tuple.Create('r', 1),
                Tuple.Create('y', 1),
                Tuple.Create('t', 1),
                Tuple.Create('h', 1),
                Tuple.Create('i', 1),
                Tuple.Create('n', 1),
                Tuple.Create('g', 1)

            }));
    }
    [Test]
    public void TestCase3()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("capybara"), Is.EqualTo(new List<Tuple<char, int>>() {
                Tuple.Create('c', 1),
                Tuple.Create('a', 3),
                Tuple.Create('p', 1),
                Tuple.Create('y', 1),
                Tuple.Create('b', 1),
                Tuple.Create('r', 1)
            }));
    }
    [Test]
    public void TestCase4()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("macarena"), Is.EqualTo(new List<Tuple<char, int>>() {
                Tuple.Create('m', 1),
                Tuple.Create('a', 3),
                Tuple.Create('c', 1),
                Tuple.Create('r', 1),
                Tuple.Create('e', 1),
                Tuple.Create('n', 1)
            }));
    }
    [Test]
    public void TestCase5()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("ymcaymca"), Is.EqualTo(new List<Tuple<char, int>>() {
                Tuple.Create('y', 2),
                Tuple.Create('m', 2),
                Tuple.Create('c', 2),
                Tuple.Create('a', 2)
            }));
    }
}