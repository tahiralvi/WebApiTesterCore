using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using WebApiTesterCore.Model;

namespace WebApiTesterCore.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
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
        public string Post([FromBody] ConfigurationDto dto)
        {
            return Ok().ToString() + " " + JsonConvert.SerializeObject(dto);
        }

        // POST api/<TestController>/PostOrder
        [HttpPost]
        public string PostOrder([FromBody] WebhookOrderResponseDto dto)
        {
            return Ok().ToString() + " " + JsonConvert.SerializeObject(dto);
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
    }
}
