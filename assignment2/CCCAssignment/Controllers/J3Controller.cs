using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CCCAssignment.Controllers
{
    [ApiController]
    [Route("api/J3")]
    public class J3Controller : ControllerBase
    {
        /// <summary>
        /// Solves a J3 problem from a previous CCC contest (Reverse String).
        /// </summary>
        /// <param name="inputData">The input string.</param>
        /// <returns>The reversed string.</returns>
        [HttpPost("ReverseString")]
        public IActionResult ReverseString([FromForm] string inputData)
        {
            string result = new string(inputData.Reverse().ToArray());
            return Ok(result);
        }
    }
}
