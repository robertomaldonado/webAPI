using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sample.WebAPI.Controllers
{
    [RoutePrefix("api/Advanced")]
    public class AdvancedController : ApiController
    {
        //Advanced methods that use GET
        //1.Quadratic Eq
        [Route("QuadEq/{a}/{b}/{c}")]
        [HttpGet]
        public async Task<IHttpActionResult> QuadEq(int a, int b, int c)
        {
            return Ok (-b + (Math.Sqrt ( Math.Pow(-b, 2) - (4*a*c) )) /(2*a));
        }
        //2.Vertex of parabola
        [Route("Vertex/{num_a}/{num_b}")]
        [HttpGet]
        public async Task<IHttpActionResult> Vertex(int num_a, int num_b)
        {
            return Ok(0);
        }
        //3.Slope by coordinates
        [Route("Slope/{x1}/{y1}/{x2}/{y2}")]
        [HttpGet]
        public async Task<IHttpActionResult> Slope(int x1, int y1, int x2, int y2)
        {
            return Ok(0);
        }
        //4.Random in range
        [Route("Random/{min}/{max}")]
        [HttpGet]
        public async Task<IHttpActionResult> Random(int min, int max)
        {
            return Ok(0);
        }
        //5.AreaTriangle
        [Route("AreaTriangle/{base_triangle}/{height}")]
        [HttpGet]
        public async Task<IHttpActionResult> AreaTriangle(int base_triangle, int height)
        {
            return Ok(0);
        }
        //6.AreaRectangle
        [Route("AreaRectangle/{width}/{length}")]
        [HttpGet]
        public async Task<IHttpActionResult> AreaRectangle(int width, int length)
        {
            return Ok(0);
        }
        //7.AreaCircle
        [Route("AreaCircle/{radius}")]
        [HttpGet]
        public async Task<IHttpActionResult> AreaCircle(int radius)
        {
            return Ok(0);
        }
        //8.Fibonacci
        [Route("Fibonacci/{index}")]
        [HttpGet]
        public async Task<IHttpActionResult> Fibonacci(int index)
        {
            return Ok(0);
        }
        /*
        //Advanced methods that use POST
        //1.Quadratic Eq
        [Route("QuadEq/{num_a}/{num_b}/{num_c}")]
        [HttpPost]
        public async Task<IHttpActionResult> QuadEqPost(int num_a, int num_b, int num_c)
        {
            return Ok(0);
        }
        //2.Vertex of parabola
        [Route("Vertex/{num_a}/{num_b}/}")]
        [HttpPost]
        public async Task<IHttpActionResult> VertexPost(int num_a, int num_b)
        {
            return Ok(0);
        }
        //3.Slope by coordinates
        [Route("Slope/{num_a}/{num_b}/{num_c}")]
        [HttpPost]
        public async Task<IHttpActionResult> SlopePost(int x1, int y1, int x2, int y2)
        {
            return Ok(0);
        }
        //4.Random in range
        [Route("Random/{min}/{max}}")]
        [HttpPost]
        public async Task<IHttpActionResult> RandomPost(int min, int max)
        {
            return Ok(0);
        }
        //5.AreaTriangle
        [Route("AreaTriangle/{base_triangle}/{height}")]
        [HttpPost]
        public async Task<IHttpActionResult> AreaTrianglePost(int base_triangle, int height)
        {
            return Ok(0);
        }
        //6.AreaRectangle
        [Route("AreaRectangle/{width}/{length}")]
        [HttpPost]
        public async Task<IHttpActionResult> AreaRectanglePost(int width, int length)
        {
            return Ok(0);
        }
        //7.AreaCircle
        [Route("AreaCicle/{radius}")]
        [HttpPost]
        public async Task<IHttpActionResult> AreaCirclePost(int radius)
        {
            return Ok(0);
        }
        //8.Fibonacci
        [Route("Fibonacci/{index}")]
        [HttpPost]
        public async Task<IHttpActionResult> FibonacciPost(int index)
        {
            return Ok(0);
        }
        */


        /*
         1. QuadraticEquation(a,b,c): find the roots of f(x) = ax^2+bx+c using
quadratic equation
         2. Vertex(a,b): return the vertex of the parabola f(x)= ax^2+bx+c
        3. Slope(x1,y1,x2,y2): return the slope given two points (x1,y1) and (x2,y2)
        4. Random(min, max): return a random integer between min and max
        5. AreaTriangle(base, height): return the area of a triangle with the provided
base and height
        6. AreaRectangle(length, width): return the area of a rectangle with the
provided length and width
        7. AreaCircle(radius): return the area of a circle with the provided radius
        8. Fibonacci(n): return the nth fibonacci number*/
    }
}
