using Design_Pattern.Customer.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Design_Pattern_Customer.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost("{type}")]
        public async Task<ActionResult> Post([FromBody] CustomerBase customerBase, string type)
        {
            var entity = CustomerFactory.Create(type);
            entity.CustomerName = customerBase.CustomerName;
            entity.PhoneNumber = customerBase.PhoneNumber;
            entity.Address = customerBase.Address;
            entity.BillAmount = customerBase.BillAmount;
            entity.BillDate = customerBase.BillDate;
            entity.Validate();
            return Ok(entity);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}