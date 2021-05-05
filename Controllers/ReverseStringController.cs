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
    public class ReverseStringController : ControllerBase
    {
        [HttpGet]
        public string BackwardsWords(string str)
        {
            char[] stringReversed = str.Reverse().ToArray();
            return new string(stringReversed);

            // or....

            // return new String(str.Reverse().ToArray());
        }
    }
}