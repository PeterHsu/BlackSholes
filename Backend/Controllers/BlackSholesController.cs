using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TA;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    public class BlackSholesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            BlackSholes bs = new BlackSholes();
            return Ok(bs.Greeting("Peter"));
        }
        // GET api/values/5
        [HttpGet("Call")]
        public IActionResult GetCall(double s, double k, double t, double r, double v)
        {
            BlackSholes bs = new BlackSholes();
            return Ok(bs.GetFairPrice(s,k,t,r,v,EnumOptionType.Call));
        }
        [HttpGet("Put")]
        public IActionResult GetPut(double s, double k, double t, double r, double v)
        {
            BlackSholes bs = new BlackSholes();
            return Ok(bs.GetFairPrice(s,k,t,r,v,EnumOptionType.Put));
        }
    }
}
