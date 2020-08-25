using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartTest.Business.Interface;
using SmartTest.DataAccess.Models;

namespace SmartTest.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
      private readonly IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        /// <summary>
        /// Get persons.
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet("GetPersons")]
        public IActionResult GetPersons()
        {
            var response = _personBusiness.GetPersons();
            return Ok(response);
        }

        /// <summary>
        /// Create person.
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpPost("CreatePerson")]
        public IActionResult CreatePerson(Person person)
        {
            var response = _personBusiness.CreatePerson(person);

            return Ok(response);
        }
        /// <summary>
        /// Delete Person.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("DeletePerson/{personid}")]
        public IActionResult DeletePerson(string personid)
        {
            var response = _personBusiness.DeletePerson(personid);
            if (response.ResponseCode == System.Net.HttpStatusCode.BadRequest)
            {
                return BadRequest();
            }
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdatePerson")]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            var response = _personBusiness.UpdatePerson(person);
            return Ok(response);
        }


        /// <summary>
        /// Get Person Types.
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [HttpGet("GetPersonTypes")]
        public IActionResult GetPersonTypes()
        {
            var response = _personBusiness.GetPersonTypes();

            return Ok(response);
        }

    }
}
