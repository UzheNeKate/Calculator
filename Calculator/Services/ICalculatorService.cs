namespace Calculator.Services;

public interface ICalculatorService
{
    double Sum(double a, double b);
    double Subtract(double a, double b);
    double Divide(double a, double b);
    double Multiply(double a, double b);
}