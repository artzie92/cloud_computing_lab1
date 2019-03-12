using Lab1_aziemianski.Rest.Context;
using Lab1_aziemianski.Rest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Lab1_aziemianski.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly AzureDbEntities context;

        public PeopleController(AzureDbEntities context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            var people = context.People.ToList();
            return people;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = new Person(); //TODO: get person from database
            return person;
        }

        [HttpPost]
        public void Post([FromBody] Person value)
        {
            //TODO: save person to database
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person value)
        {
            //TODO: Update person in database
        }

      
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //TODO: Remove person from database
        }
    }
}