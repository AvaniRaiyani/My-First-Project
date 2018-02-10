using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AvanisHerbalSalon.Models;
using AvanisHerbalSalon.Data;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AvanisHerbalSalon.API
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        ApplicationDbContext _db;

        public ItemsController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET: api/values
        [HttpGet]
        public List<Item> Get()
        {
            return _db.Items.ToList();
        }


        [HttpGet("haircare")]
        public List<Item> Gethaircare()
        {
            List<Item> haircare = (from h in _db.Items
                                    where h.Category.Id == 6
                                    select h).ToList();

            return haircare;
        }


        [HttpGet("skincare")]
        public List<Item> Getskincare()
        {
            List<Item> skincare = (from s in _db.Items
                                    where s.Category.Id == 7
                                    select s).ToList();

            return skincare;
        }

        [HttpGet("massage")]
        public List<Item> Getmassage()
        {
            List<Item> massage = (from m in _db.Items
                                   where m.Category.Id == 8
                                   select m).ToList();

            return massage;
        }

        [HttpGet("nailcare")]
        public List<Item> Getnailcare()
        {
            List<Item> nailcare = (from n in _db.Items
                                   where n.Category.Id == 9
                                   select n).ToList();

            return nailcare;
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _db.Items.FirstOrDefault();
        }


        // POST api/values
        [HttpPost]
     
        public IActionResult Post([FromBody]Item item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            else if (item.Id == 0)
            {
                Category getCat = (from c in _db.Categories
                                   where c.Id == item.Category.Id
                                   select
                                   c).FirstOrDefault();
                item.Category = getCat;
                _db.Items.Add(item);
                _db.SaveChanges();
                return Ok();
            }
            else {
                _db.Items.Update(item);
                _db.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
