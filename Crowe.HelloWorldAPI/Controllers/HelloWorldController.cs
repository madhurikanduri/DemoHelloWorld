using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crowe.API.ServiceLayer.Interfaces;
using Crowe.API.ServiceLayer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crowe.HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private IMessageServiceLayer _messageServiceLayer;

        public HelloWorldController(IMessageServiceLayer messageServiceLayer)
        {
            _messageServiceLayer = messageServiceLayer;
        }

        [HttpGet]
        [Route("Message")]
        public string GetMessage()
        {
            MessageServiceModel msgModel = new MessageServiceModel();
            msgModel = _messageServiceLayer.GetMessage();

            if (msgModel == null)
                return "No Message";
            else
                
            return msgModel.message;

            
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
