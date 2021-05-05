using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitsExplosionController : ControllerBase
    {
        [HttpGet]
        public string Explode(string s)
        {
            var result = "";
            foreach (var digit in s)
            {
                var numChar = digit.ToString();

                var num = int.Parse(numChar);

                for (var i = 0; i < num; i++)
                {
                    result += num;
                }
            }
            return result;
        }

    }
}