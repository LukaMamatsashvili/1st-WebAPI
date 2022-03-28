using API___დამოუკიდებლად.Models;
using API___დამოუკიდებლად.PersonData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace API___დამოუკიდებლად.Controllers
{
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPerson PersonData;

        public PersonController(IPerson PD)
        {
            PersonData = PD;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GET()
        {
            return Ok(PersonData.ShowAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GET(Guid id)
        {
            return Ok(PersonData.ShowOne(id));
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DELETE(Guid id)
        {
            PersonData.RemovePerson(id);
            return Ok();
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult POST(Person P)
        {
            PersonData.AddPerson(P);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + 
                HttpContext.Request.Path + "/" + P.id, P);
        }

        [HttpPut]
        [Route("api/[controller]/{id}")]
        public IActionResult PUT(Guid id, Person P)
        {
            PersonData.EditPerson(id, P);
            return Ok();
        }
    }
}
