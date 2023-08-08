using Microsoft.AspNetCore.Mvc;

namespace SwaggerComAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Realiza a soma entre x e y
        /// </summary>
        /// <param name="x">Primeiro número a ser somado</param>
        /// <param name="y">Segundo número a ser somado</param>
        /// <returns></returns>
        /// <response code="200">Retorno quando a requisição é realizada com sucesso</response>
        /// <response code="500">Retorno quando ocorre algum erro no servidor</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorMessage))]
        [HttpGet("add/{x}/{y}")]
        public int Add(int x, int y)
        {
            _logger.LogInformation($"{x} plus {y} is {x + y}");
            return x + y;
        }

        /// <summary>
        /// Perform x - y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x subtract y</returns>
        [HttpGet("subtract/{x}/{y}")]
        public int Subtract(int x, int y)
        {
            _logger.LogInformation($"{x} subtract {y} is {x - y}");
            return x - y;
        }

        /// <summary>
        /// Perform x * y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x multiply y</returns>
        [HttpGet("multiply/{x}/{y}")]
        public int Multiply(int x, int y)
        {
            _logger.LogInformation($"{x} multiply {y} is {x * y}");
            return x * y;
        }

        /// <summary>
        /// Perform x / y.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x divide y</returns>
        [HttpGet("divide/{x}/{y}")]
        public int Divide(int x, int y)
        {
            _logger.LogInformation($"{x} divide {y} is {x / y}");
            return x / y;
        }
    }
}

class ErrorMessage
{
    public string Message { get; set; }
}