namespace Calculator.Services;

public class CalculatorService : ICalculatorService
{
    public double Sum(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;
    
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("The second argument must be not null!");
        }

        return a / b;
    }
}