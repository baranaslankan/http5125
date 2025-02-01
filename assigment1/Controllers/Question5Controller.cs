using Microsoft.AspNetCore.Mvc;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q5")]
    public class Question5Controller : ControllerBase
    {
        /// <summary>
        /// Returns an acknowledgment of the secret integer.
        /// </summary>
        /// <param name="secret">The secret number.</param>
        /// <returns>A string message confirming the secret.</returns>
        /// <example>POST http://localhost:5000/api/q5/secret</example>
        [HttpPost("secret")]
        public ActionResult<string> PostSecret([FromBody] int secret)
        {
            return Ok($"Shh.. the secret is {secret}");
        }
    }
}
