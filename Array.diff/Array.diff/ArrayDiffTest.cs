namespace Array.diff;

public class Tests
{
    

    [Test]
    public void Test1()
    {
        Assert.That(Array.ArrayDiff(new int[] {1, 2},    new int[] {1}), Is.EqualTo(new int[] {2}));
    }
    [Test]
    public void Test2()
    {
        Assert.That(Array.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}), Is.EqualTo(new int[] {2, 2}));
    }

    [Test]
    public void Test3()
    {
        Assert.That(Array.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}), Is.EqualTo(new int[] {1}));
    }
    [Test]
    public void Test4()
    {
        Assert.That(Array.ArrayDiff(new int[] {1, 2, 2}, System.Array.Empty<int>()), Is.EqualTo(new int[] {1, 2, 2}));
    }
    [Test]
    public void Test5()
    {
        Assert.That(Array.ArrayDiff(System.Array.Empty<int>(),        new int[] {1, 2}), Is.EqualTo(System.Array.Empty<int>()));
    }
    [Test]
    public void Test6()
    {
        Assert.That(Array.ArrayDiff(new int[] {1, 2, 3}, new int[] {1, 2}), Is.EqualTo(new int[] {3}));
    }
}
