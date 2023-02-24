namespace ListFiltering;

public class Tests
{
    [Test]
    public void TestCase1()
    {
        var list = new List<object>(){1,2,"a","b"};
        var expected = new List<int>(){1,2};
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
    
    [Test]
    public void TestCase2()
    {
        var list = new List<object>(){1,"a","b",0,15};
        var expected = new List<int>(){1,0,15};
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
    
    [Test]
    public void TestCase3()
    {
        var list = new List<object>(){1,2,"aasf","1","123",123};
        var expected = new List<int>(){1,2,123};
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
    
    [Test]
    public void TestCase4()
    {
        var list = new List<object>(){5,2,"0","10","123",123};
        var expected = new List<int>(){5,2,123};
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
    
    [Test]
    public void TestCase5()
    {
        var list = new List<object>(){1,2,123};
        var expected = new List<int>(){1,2,123};
        var actual = ListFiltering.GetIntegersFromList(list);
        Assert.IsTrue(expected.SequenceEqual(actual));
    }
}