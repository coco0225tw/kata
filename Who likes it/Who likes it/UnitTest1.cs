namespace Who_likes_it;

public class Tests
{

    [Test]
    public void when_input_array_is_empty()
    {
        Assert.That(Kata.Likes(Array.Empty<string>()), Is.EqualTo("no one likes this"));

    }
    [Test]
    public void when_input_array_contains_one_person()
    {
        Assert.That(Kata.Likes(new string[] {"Peter"}), Is.EqualTo("Peter likes this"));
    }
}