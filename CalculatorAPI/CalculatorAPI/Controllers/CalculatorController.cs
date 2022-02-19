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

        /// <summary>
        /// Calculator api end point to perform addition opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        [HttpGet("Addition")]
        public int Addition(int i, int j)
        {
            return _math.Addition(i, j);
        }

        /// <summary>
        /// Calculator api end point to perform substraction opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        [HttpGet("Subtraction")]
        public int Subtraction(int i, int j)
        {
            return _math.Subtraction(i, j);
        }

        /// <summary>
        /// Calculator api end point to perform multiplication opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        [HttpGet("Multiplication")]
        public int Multiplication(int i, int j)
        {
            return _math.Multiplication(i, j);
        }

        /// <summary>
        /// Calculator api end point to perform division opertion on two integers
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        [HttpGet("Division")]
        public int Division(int i, int j)
        {
            return _math.Division(i, j);
        }
    }
}
