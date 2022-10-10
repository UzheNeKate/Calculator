using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorController(ICalculatorService calculatorService) =>
        _calculatorService = calculatorService;


    [HttpGet]
    public IActionResult Sum(double a, double b)
    {
        return Ok(_calculatorService.Sum(a, b));
    }

    [HttpGet]
    public IActionResult Sub(double a, double b)
    {
        return Ok(_calculatorService.Subtract(a, b));
    }

    [HttpGet]
    public IActionResult Div(double a, double b)
    {
        try
        {
            return Ok(_calculatorService.Divide(a, b));
        }
        catch (DivideByZeroException e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public IActionResult Mult(double a, double b)
    {
        return Ok(_calculatorService.Multiply(a, b));
    }
}