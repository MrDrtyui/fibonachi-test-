using MathLibrary;
using Xunit;

namespace MathLibrary.Tests;

public class NumberUtilsTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(15, 610)]
    public void Fibonacci_ReturnsExpectedValue(int n, int expected)
    {
        Assert.Equal(expected, NumberUtils.Fibonacci(n));
    }

    [Fact]
    public void Fibonacci_NegativeInput_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => NumberUtils.Fibonacci(-1));
    }
}
