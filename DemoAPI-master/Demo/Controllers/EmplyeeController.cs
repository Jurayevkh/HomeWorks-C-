﻿using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.Interfaces;
namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmplyeeController(IEmployeeRepository emplyeeRepository)
        {
            this.employeeRepository = emplyeeRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromForm] EmployeeDtos em)
        {
            await employeeRepository.CreateEmplyeeAsync(em);

            return Ok("Created");
        }
        [HttpGet("GetEmplyees")]
        public async Task<IActionResult> GetEmplyees()
        {
            var result = await employeeRepository.GetAllAsync();

            return Ok(result);
        }
        [HttpGet("GetEmplyeeById")]
        public async Task<IActionResult> GetEmplyeeById(Guid employeeId)
        {
            var res =  await employeeRepository.GetEmplyeeByIdAsync(employeeId);

            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(Guid employeeId)
        {
            await employeeRepository.DeleteEmplyee(employeeId);

            return Ok("Deleted");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmplyee(Guid emplyeeId, EmployeeDtos emplyee)
        {
            await employeeRepository.UpdateEmplyee(emplyeeId, emplyee);

            return Ok("Updated");
        }
    }
}