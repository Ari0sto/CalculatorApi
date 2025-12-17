using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public int Sum(int a, int b)
        {
            return a + b;
        }


        [HttpGet("sub")]
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
