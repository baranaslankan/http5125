using Microsoft.AspNetCore.Mvc;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q3")]
    public class Question3Controller : ControllerBase
    {
        /// <summary>
        /// Returns the cube of the given number.
        /// </summary>
        /// <param name="baseNumber">The base number to cube.</param>
        /// <returns>The cubed value.</returns>
        /// <example>GET http://localhost:5000/api/q3/cube/4</example>
        [HttpGet("cube/{baseNumber}")]
        public ActionResult<int> GetCube(int baseNumber)
        {
            return Ok(baseNumber * baseNumber * baseNumber);
        }
    }
}
