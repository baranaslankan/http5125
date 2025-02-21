using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CCCAssignment.Controllers
{
    [ApiController]
    [Route("api/J2")]
    public class J2Controller : ControllerBase
    {
        private static readonly Dictionary<string, int> PepperSHU = new()
        {
            { "Poblano", 1500 },
            { "Mirasol", 6000 },
            { "Serrano", 15500 },
            { "Cayenne", 40000 },
            { "Thai", 75000 },
            { "Habanero", 125000 }
        };

        /// <summary>
        /// Calculates the total spiciness of a chili based on the peppers used.
        /// </summary>
        /// <param name="ingredients">A comma-separated list of pepper names.</param>
        /// <returns>The total Scoville Heat Units (SHU).</returns>
        [HttpGet("ChiliPeppers")]
        public IActionResult CalculateSpiciness([FromQuery] string ingredients)
        {
            string[] peppers = ingredients.Split(',');
            int totalSHU = peppers.Sum(pepper => PepperSHU.GetValueOrDefault(pepper.Trim(), 0));
            return Ok(totalSHU);
        }

        /// <summary>
        /// Solves a different J2 problem from a previous CCC contest (Occupy Parking).
        /// </summary>
        /// <param name="yesterday">String representing yesterday's parking.</param>
        /// <param name="today">String representing today's parking.</param>
        /// <returns>Number of occupied spots both days.</returns>
        [HttpGet("OccupyParking")]
        public IActionResult SolveOccupyParking([FromQuery] string yesterday, [FromQuery] string today)
        {
            if (yesterday.Length != today.Length)
            {
                return BadRequest("Input strings must have the same length.");
            }

            int occupiedCount = 0;
            for (int i = 0; i < yesterday.Length; i++)
            {
                if (yesterday[i] == 'C' && today[i] == 'C')
                {
                    occupiedCount++;
                }
            }
            return Ok(occupiedCount);
        }
    }
}
