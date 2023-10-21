using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Services.DataContext;
using Services.Dtos;
using Services.Interfaces;

namespace Services.Services
{
    public class EmplyeeRepository : IEmployeeRepository
    {
        private readonly DataContexts contexts;

        public EmplyeeRepository(DataContexts contexts)
        {
            this.contexts = contexts;
        }

        public async Task CreateEmplyeeAsync(EmployeeDtos company)
        {
            var newEmployee = new Employee()
            {
                Id = new Guid(),
                Email = company.Email,
                FirstName = company.FirstName,
                LastName = company.LastName,
                Phone = company.Phone,
                CompanyId = company.CompanyId,
            };

            await contexts.Employees.AddAsync(newEmployee);
            await contexts.SaveChangesAsync();

        }

        public async Task DeleteEmplyee(Guid employeeId)
        {
            var employee = await contexts.Employees.FirstOrDefaultAsync(X => X.Id == employeeId);

            contexts.Employees.Remove(employee);
            await contexts.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var employees = await contexts.Employees.Where(x => x.CompanyId == x.Company.Id).ToListAsync();

            return employees;
        }

        public async Task<Employee> GetEmplyeeByIdAsync(Guid CompanyId)
        {
            var employee = await contexts.Employees.FirstOrDefaultAsync(x => x.Id == CompanyId);

            return employee;
        }

        public async Task UpdateEmplyee(Guid employeeId, EmployeeDtos employee)
        {
            var emp = await contexts.Employees.FirstOrDefaultAsync(x => x.Id == employeeId);

            if(emp != null)
            {
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Email = employee.Email;
                emp.Phone = employee.Phone;
                emp.CompanyId = employee.CompanyId;

                contexts.Employees.Update(emp);
                await contexts.SaveChangesAsync();
            }
        }
    }
}
