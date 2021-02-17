using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiTesterCore.Model;

namespace WebApiTesterCore.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInformation("The Test.Get method has been accessed");
            return new string[] { "TestService", " UP and Running" };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Ok().ToString() + " " + id;
        }

        // POST api/<TestController>/Post
        [HttpPost]
        public ActionResult Post([FromBody] ConfigurationDto dto)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(dto));

            return Ok();
        }

        // POST api/<TestController>/PostOrder
        [HttpPost]
        public async Task<ActionResult> OrderCreatedViaWhook([FromBody] WebhookOrderResponseDto dto)
        {
            _logger.Log(LogLevel.Information, JsonConvert.SerializeObject(dto));

            return Ok();
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return Ok().ToString() + " " + value;
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return Ok().ToString() + " " + id;
        }

        [HttpGet]
        public IActionResult CheckHealth()
        {
            Console.WriteLine($"Test/CheckHealth - {DateTime.Now}");
            return Ok("Test API App -  Health Check Passed.");
        }
    }
}