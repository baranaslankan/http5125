using Microsoft.AspNetCore.Mvc;
using System;

namespace assigment1.Controllers
{
    [ApiController]
    [Route("api/q8")]
    public class Question8Controller : ControllerBase
    {
        private const double SmallPrice = 25.50;
        private const double LargePrice = 40.50;
        private const double TaxRate = 0.13;

        /// <summary>
        /// Calculates the total price for SquashFellows plushies order.
        /// </summary>
        /// <param name="small">Number of small plushies.</param>
        /// <param name="large">Number of large plushies.</param>
        /// <returns>A checkout summary.</returns>
        /// <example>POST http://localhost:5000/api/q8/squashfellows</example>
        [HttpPost("squashfellows")]
        public ActionResult<string> CalculateOrder([FromForm] int small, [FromForm] int large)
        {
            double subtotal = (small * SmallPrice) + (large * LargePrice);
            double tax = Math.Round(subtotal * TaxRate, 2);
            double total = Math.Round(subtotal + tax, 2);

            string response = $"{small} Small @ ${SmallPrice} = ${small * SmallPrice:F2}; " +
                              $"{large} Large @ ${LargePrice} = ${large * LargePrice:F2}; " +
                              $"Subtotal = ${subtotal:F2}; Tax = ${tax:F2} HST; Total = ${total:F2}";

            return Ok(response);
        }
    }
}
