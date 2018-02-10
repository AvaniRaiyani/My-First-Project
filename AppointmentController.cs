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
    public class AppointmentController : Controller
    {
        private IRepository _repo;

        public AppointmentController(IRepository repo)
        {
            _repo = repo;
        }
    
    // GET: api/values
    [HttpGet]
    public IEnumerable<Appointment> Get()
    {
        return _repo.ListAppointments();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public Appointment Get(int id)
    {
        return _repo.FindAppointment(id);
    }

    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]Appointment appointment)
    {
        if (appointment.Id == 0)
        {
            _repo.CreateAppointment(appointment);
        }
        else
        {
            _repo.UpdateAppointment(appointment);
        }
        
        return Ok(appointment);
    }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
        _repo.DeleteAppointment(id);
        return Ok();
        }
    }
}
