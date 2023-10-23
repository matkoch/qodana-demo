using ClassLibrary1;
using FluentAssertions;

namespace TestProject1;

public class FizzBuzzerTests
{
    [Fact]
    public void TestFizz()
    {
        FizzBuzzer.FizzBuzz(3).Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void TestBuzz(int i)
    {
        FizzBuzzer.FizzBuzz(i).Should().Be("Buzz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void TestFizzBuzz(int i)
    {
        FizzBuzzer.FizzBuzz(i).Should().Be("FizzBuzz");
    }
}
