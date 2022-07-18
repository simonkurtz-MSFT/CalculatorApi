using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    //[Route("[controller]")]   //comment out to omit "/Calculator" in the method name
    public class CalculatorController : Controller
    {

        #region Public Actions

        /// <summary>
        /// Adds two addends for a sum.
        /// </summary>
        /// <param name="addend1"></param>
        /// <param name="addend2"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Add(decimal addend1, decimal addend2)
        {
            return Ok(addend1 + addend2);
        }

        /// <summary>
        /// Divides a dividend by a divisor for a quotient.
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Multiplies two factors for a product.
        /// </summary>
        /// <param name="factor1"></param>
        /// <param name="factor2"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Multiply(decimal factor1, decimal factor2)
        {
            return Ok(factor1 * factor2);
        }

        /// <summary>
        /// Subtracts a subtrahend from a minuend for a difference.
        /// </summary>
        /// <param name="minuend"></param>
        /// <param name="subtrahend"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]")]
        public ActionResult<decimal> Subtract(decimal minuend, decimal subtrahend)
        {
            return Ok(minuend - subtrahend);
        }

        #endregion

    }
}
