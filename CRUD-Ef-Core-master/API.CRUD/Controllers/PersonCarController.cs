using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.CRUD
{
    [Route("api/[controller]")]
    public class PersonCarController : Controller
    {
        // GET: api/values
        private readonly IPersonCarRepo personCarRepo;
        private readonly IConfiguration _configuration;
        public PersonCarController(IPersonCarRepo personCarRepo, IConfiguration configuration)
        {
            this.personCarRepo = personCarRepo;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Add(int personId,int carId)
        {
            await personCarRepo.BuyCar(carId,personId);

            return Ok("Created");
        }

        [HttpPatch("UpdatePersonCar")]
        public async Task<IActionResult> UpdatePersonCar(int Id, [FromForm] PersonCarDto personCar)
        {
            await personCarRepo.UpdatePersonCar(Id,personCar);

            return Ok("Updated");
        }


        [HttpDelete]
        public async Task<IActionResult> DeletePersonCar(int Id)
        {
            await personCarRepo.RemovePersonCar(Id);

            return Ok("Deleted");
        }

    }
}

