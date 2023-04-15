using NUnit.Framework;

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
        Assert.That(Kata.Likes(new[] {"Peter"}), Is.EqualTo("Peter likes this"));
    }
    
    [Test]
    public void when_input_array_contains_two_person()
    {
        Assert.That(Kata.Likes(new[] {"Jacob", "Alex"}), Is.EqualTo("Jacob and Alex like this"));
    }
    
    [Test]
    public void when_input_array_contains_three_person()
    {
        Assert.That(Kata.Likes(new[] {"Max", "John", "Mark"}), Is.EqualTo("Max, John and Mark like this"));
    }

    [Test]
    public void when_input_array_contains_four_person()
    {
        Assert.That(Kata.Likes(new[] {"Alex", "Jacob", "Mark", "Max"}), Is.EqualTo("Alex, Jacob and 2 others like this"));
    }
    
    [Test]
    public void when_input_array_contains_six_person()
    {
        Assert.That(Kata.Likes(new[] {"Alex", "Jacob", "Mark", "Max", "Ray", "Eric"}), Is.EqualTo("Alex, Jacob and 4 others like this"));
    }
    
    [Test]
    public void when_input_array_contains_invalid_string()
    {
        Assert.That(Kata.Likes(new[] {"Alex", "Jacob", "Mark", " ", "  ", "", "Jason"}), Is.EqualTo("Alex, Jacob and 2 others like this"));
    }
}