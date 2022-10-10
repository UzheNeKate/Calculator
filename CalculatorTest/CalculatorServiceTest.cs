using System;
using Calculator.Services;
using Xunit;

namespace CalculatorTest;

public class CalculatorServiceTest
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorServiceTest()
    {
        _calculatorService = new CalculatorService();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(2.44, 3.672, 6.112)]
    public void Sum_ReturnRightResult(double a, double b, double expectedResult)
    {
        var actual = _calculatorService.Sum(a, b);

        Assert.Equal(expectedResult, actual);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(-4, -6, 2)]
    [InlineData(-2, 0, -2)]
    [InlineData(2.44, 3.67, -1.23)]
    public void Subtract_ReturnRightResult(double a, double b, double expectedResult)
    {
        var actual = _calculatorService.Subtract(a, b);

        Assert.Equal(expectedResult, actual);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(-4, -6, 24)]
    [InlineData(-2, 0, 0)]
    [InlineData(2.44, 2, 4.88)]
    public void Multiply_ReturnRightResult(double a, double b, double expectedResult)
    {
        var actual = _calculatorService.Multiply(a, b);

        Assert.Equal(expectedResult, actual);
    }

    [Theory]
    [InlineData(1, 2, 0.5)]
    [InlineData(-4, -2, 2)]
    [InlineData(0, 5, 0)]
    [InlineData(2.44, 2, 1.22)]
    public void Divide_ReturnRightResult(double a, double b, double expectedResult)
    {
        var actual = _calculatorService.Divide(a, b);

        Assert.Equal(expectedResult, actual);
    }

    [Fact]
    public void Divide_ThrowsDivideByZeroException_IfArgumentBIsZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(5, 0));
    }
}