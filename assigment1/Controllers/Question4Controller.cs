using Microsoft.AspNetCore.Mvc;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q4")]
    public class Question4Controller : ControllerBase
    {
        /// <summary>
        /// Returns the start of a knock-knock joke.
        /// </summary>
        /// <returns>"Who's there?"</returns>
        /// <example>POST http://localhost:5000/api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public ActionResult<string> KnockKnock()
        {
            return Ok("Who’s there?");
        }
    }
}
