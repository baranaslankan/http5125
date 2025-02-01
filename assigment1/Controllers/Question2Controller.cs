using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q2")]
    public class Question2Controller : ControllerBase
    {
        /// <summary>
        /// Returns a greeting for the given name.
        /// </summary>
        /// <param name="name">The name to greet.</param>
        /// <returns>A greeting message.</returns>
        /// <example>GET http://localhost:5000/api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public ActionResult<string> GetGreeting([FromQuery] string name)
        {
            // Check for non-alphabetic characters
            if (ContainsNonAlpha(name))
            {
                return BadRequest("The name contains non-alphabetic characters.");
            }

            return Ok($"Hi {name}!");
        }

        private bool ContainsNonAlpha(string str)
        {
            return Regex.IsMatch(str, @"[^a-zA-Z]");
        }
    }
}
