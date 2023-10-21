using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.CRUD
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET: api/values
        private readonly IPersonRepository personRepository;
        private readonly IConfiguration _configuration;
        public PersonController(IPersonRepository personRepository, IConfiguration configuration)
        {
            this.personRepository = personRepository;
            _configuration = configuration;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromForm] PersonDto person)
        {
            await personRepository.AddPersonAsync(person);

            return Ok("Created");
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await personRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int personId)
        {
            var person = await personRepository.GetPersonByIdAsync(personId);

            return Ok(person);
        }

        [HttpPatch("UpdatePerson")]
        public async Task<IActionResult> UpdatePerson(int personId, string Name, string Address, string Email)
        {
            await personRepository.UpdatePersonAsync(personId, Name, Address, Email);

            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePerson(int Id)
        {
            await personRepository.DeletePerson(Id);

            return Ok("Deleted");
        }
    }
}

