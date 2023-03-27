using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorAPI.Context;
using ActorAPI.Models;
using ActorAPI.Services;
using ActorAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActorAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IActorService _iactorService;

        public ValuesController(IActorService actorService)
        {
            _iactorService = actorService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Actor>> Get()
        {
            var o =  _iactorService.getActors();
            if( o == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(o);
            }
        }

        //post a more than one contact      
        [HttpPost("list")]
        public void post([FromBody] List<Actor> value)
        {
                _iactorService.addActors(value);           
        }

        //// post api/<valuescontroller>
        [HttpPost]
        public ActionResult post([FromBody] Actor value)
        {
            if (value != null)
            {
                _iactorService.addActor(value);
                return Ok("Actor added");
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Actor value)
        {
            
            if (value != null)
            {
                _iactorService.updateActor(value);
                return Ok("Actor updated");

            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _iactorService.deleteActor(id);
            
        }

        [HttpGet("{id}")]
        public ActionResult<Actor> getById(int id)
        {
           
           var a = _iactorService.getActorById(id);
            if( a == null )
            {
                return NotFound();
            }
            else
            {
               return Ok(a);
            }
           
        }
    }
}
