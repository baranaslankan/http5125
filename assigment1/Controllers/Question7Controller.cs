using Microsoft.AspNetCore.Mvc;
using System;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q7")]
    public class Question7Controller : ControllerBase
    {
        /// <summary>
        /// Adjusts the current date by a given number of days.
        /// </summary>
        /// <param name="days">Number of days to add or subtract.</param>
        /// <returns>Adjusted date in yyyy-MM-dd format.</returns>
        /// <example>GET http://localhost:5000/api/q7/timemachine?days=1</example>
        [HttpGet("timemachine")]
        public ActionResult<string> GetAdjustedDate([FromQuery] int days)
        {
            DateTime adjustedDate = DateTime.Today.AddDays(days);
            return Ok(adjustedDate.ToString("yyyy-MM-dd"));
        }
    }
}
