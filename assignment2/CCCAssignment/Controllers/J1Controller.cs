using Microsoft.AspNetCore.Mvc;
using System;

namespace CCCAssignment.Controllers
{
    [ApiController]
    [Route("api/J1")]
    public class J1Controller : ControllerBase
    {
        [HttpPost("Delivedroid")]
        public IActionResult CalculateScore([FromForm] int collisions, [FromForm] int deliveries)
        {
            Console.WriteLine($"Received request: collisions={collisions}, deliveries={deliveries}");

            int score = (deliveries * 50) - (collisions * 10);
            if (deliveries > collisions)
            {
                score += 500;
            }

            Console.WriteLine($"Returning score: {score}");
            return Ok(score);
        }

        /// <summary>
        /// Solves a J1 problem from a past CCC contest (Sum of Digits).
        /// </summary>
        /// <param name="number">A positive integer.</param>
        /// <returns>The sum of its digits.</returns>
        [HttpPost("SumOfDigits")]
        public IActionResult SumOfDigits([FromForm] int number)
        {
            Console.WriteLine($"Received request: number={number}");

            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"Returning sum: {sum}");
            return Ok(sum);
        }
    }
}
