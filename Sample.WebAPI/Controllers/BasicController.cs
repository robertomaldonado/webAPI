using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

namespace Calculator.WebAPI.Controllers
{
    [RoutePrefix("api/Basic")]
    public class BasicController : ApiController
    {
        [Route("Addition/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Addition(int num_1, int num_2)
        {
            return Ok(num_1 + num_2);
        }
        [Route("Subtraction/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Subtraction(int num_1, int num_2)
        {
            return Ok(num_1 - num_2);
        }
        [Route("Multiplication/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Multiplication(int num_1, int num_2)
        {
            return Ok(num_1 * num_2);
        }
        [Route("Division/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Division(int num_1, int num_2)
        {
            return Ok(num_1 / num_2);
        }
        [Route("Sqrt/{num_1}")]
        [HttpGet]
        public async Task<IHttpActionResult> Sqrt(int num_1)
        {
            return Ok(Math.Sqrt(num_1));
        }
        [Route("Pow/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Pow(int num_1, int num_2)
        {
            return Ok(Math.Pow(num_1, num_2));
        }
        [Route("Exp/{num_1}")]
        [HttpGet]
        public async Task<IHttpActionResult> Exp(int num_1)
        {
            return Ok(Math.Exp(num_1));
        }
        [Route("Log/{num_1}/{num_2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Log(int num_1, int num_2)
        {
            return Ok(Math.Log(num_2, num_1));
        }



    }
}
