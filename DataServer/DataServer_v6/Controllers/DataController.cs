namespace DataServer_v6.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        // GET api/values
        [HttpGet("getJsonCircles")]
        public JsonResult GetJsonCircles()
        {
            var rand = new Random();
            var results = new List<int>();

            for(var i = 0; i < 5; i++)
            {
                results.Add(rand.Next(1, 10));
            }


            return new JsonResult(results.ToArray());
        }
    }
}
