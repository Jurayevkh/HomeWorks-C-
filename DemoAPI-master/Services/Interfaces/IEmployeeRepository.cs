using Domain.Entities;
using Services.Dtos;

namespace Services.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task CreateEmplyeeAsync(EmployeeDtos company);
        public Task<Employee> GetEmplyeeByIdAsync(Guid CompanyId);
        public Task<List<Employee>> GetAllAsync();
        public Task DeleteEmplyee(Guid employeeId);
        public Task UpdateEmplyee(Guid employeeId, EmployeeDtos employee);
    }
}