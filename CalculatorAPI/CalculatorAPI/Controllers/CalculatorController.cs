using Calculator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMath _math;
        public CalculatorController(IMath math)
        {
            _math = math;
        }

        [HttpGet("Addition")]
        public int Addition(int i, int j)
        {
            return _math.Addition(i, j);
        }

        [HttpGet("Substraction")]
        public int Substraction(int i, int j)
        {
            return _math.Substraction(i, j);
        }

        [HttpGet("Multiplication")]
        public int Multiplication(int i, int j)
        {
            return _math.Multiplication(i, j);
        }

        [HttpGet("Division")]
        public int Divsion(int i, int j)
        {
            return _math.Division(i, j);
        }
    }
}
