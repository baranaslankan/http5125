using Microsoft.AspNetCore.Mvc;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q1")]
    public class Question1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A simple welcome string.</returns>
        /// <example>GET http://localhost:5000/api/q1/welcome</example>
        [HttpGet("welcome")]
        public ActionResult<string> GetWelcome()
        {
            return "Welcome to 5125!";
        }
    }
}
