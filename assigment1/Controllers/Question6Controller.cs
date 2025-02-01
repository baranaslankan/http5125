using Microsoft.AspNetCore.Mvc;
using System;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q6")]
    public class Question6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a regular hexagon.
        /// </summary>
        /// <param name="side">Side length of the hexagon.</param>
        /// <returns>Calculated area of the hexagon.</returns>
        /// <example>GET http://localhost:5000/api/q6/hexagon?side=1</example>
        [HttpGet("hexagon")]
        public ActionResult<double> GetHexagonArea([FromQuery] double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return Ok(area);
        }
    }
}
