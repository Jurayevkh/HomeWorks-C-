using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.CRUD
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        // GET: api/values
        private readonly ICarRepository carRepository;
        private readonly IConfiguration _configuration;
        public CarController(ICarRepository carRepository, IConfiguration configuration)
        {
            this.carRepository = carRepository;
            _configuration = configuration;
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromForm] CarDto car)
        {
            await carRepository.AddCarAsync(car);

            return Ok("Created");
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await carRepository.GetAllAsync();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int carId)
        {
            var car = await carRepository.GetCarByIdAsync(carId);

            return Ok(car);
        }

        [HttpPatch("UpdateCar")]
        public async Task<IActionResult> UpdateCar(int carId, string Model,string Brand,double Price)
        {
            await carRepository.UpdateCarAsync(carId, Model,Brand,Price);

            return Ok("Updated");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCar(int Id)
        {
            await carRepository.DeleteCar(Id);

            return Ok("Deleted");
        }
    }
}

