namespace OrderedCountofCharacters;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        Assert.That(
            OrderedCountofCharacters.OrderedCount("abracadabra"), Is.EqualTo(new List<Tuple<char, int>>() {
                new Tuple('a', 5),
                tuple('b', 2),
                tuple('r', 2),
                tuple('c', 1),
                tuple('d', 1)
            }));
    }
}