using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {

        #region Public Actions

        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Add(decimal addend1, decimal addend2)
        {
            return Ok(addend1 + addend2);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return Ok(dividend / divisor);
            } 
            else
            {
                return BadRequest("Cannot divide by 0."); 
            }

        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Multiply(decimal factor1, decimal factor2)
        {
            return Ok(factor1 * factor2);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Subtract(decimal minuend, decimal subtrahend)
        {
            return Ok(minuend - subtrahend);
        }

        #endregion

    }
}
