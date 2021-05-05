using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiceController : ControllerBase
    {
        [HttpGet("{sides}")]
        // int sides -- comes from {sides} in the HttpGet
        // int count -- comes from a query parameter
        public List<int> Roll(int sides, int count)
        {
            // Make a new list to store our integer rolls
            var rolls = new List<int>();

            // Make a random number generator
            var randomNumberGenerator = new Random();

            // Loop _count_ times
            for (var rollNumber = 0; rollNumber < count; rollNumber++)
            {
                // Grab a random roll between 1 and sides
                var roll = randomNumberGenerator.Next(sides) + 1;

                // Add that roll to the list
                rolls.Add(roll);
            }

            // Return the list
            return rolls;
        }
    }
}