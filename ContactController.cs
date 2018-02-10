using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AvanisHerbalSalon.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AvanisHerbalSalon.API
{

    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        static List<Contact> _contact = new List<Contact>
        {
            new Contact {Id = 1, Name ="", PhoneNumber = 0 , Email ="", Comment = "" },

        };

        // GET: api/values
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return _contact;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contact = _contact.Find(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(contact);
            }
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Contact contact)
        {
            _contact.Add(contact);
            return Created("/contacts/" + contact.Id, contact);
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
    
