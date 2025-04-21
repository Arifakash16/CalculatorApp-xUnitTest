using Microsoft.AspNetCore.Mvc;
using SimpleCalculatorApp;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add({num1}/{num2}")]
        public int Get(int num1, int num2)
        {
            var calculator = new Calculator();
            return calculator.Add(num1, num2);

        }
    }
}
