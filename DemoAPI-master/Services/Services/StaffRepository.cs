using Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Services.DataContexts;
using Services.Dtos;
using Services.Interfaces;

namespace Services.Services
{
    public class StaffRepository : IStaffRepository
    {
        private readonly DataContext contexts;

        public StaffRepository(DataContext contexts)
        {
            this.contexts = contexts;
        }
        public async Task AddEmployeesToStaff(Guid staffId,Guid employees)
        {
            var staff = await contexts.Staffs.FirstOrDefaultAsync(x => x.Id == staffId);

            var employee = await contexts.Employees.FirstOrDefaultAsync(x => x.Id == employees);

            EmployeeStaff employeeStaff = new EmployeeStaff();

            employeeStaff.StaffId = staff.Id;
            employeeStaff.EmployeeId = employee.Id;

            await contexts.EmployeeStaff.AddAsync(employeeStaff);
            await contexts.SaveChangesAsync();
        }
        public async Task CreateStaffAsync(StaffDtos staff)
        {
            await contexts.Staffs.AddAsync(staff.Adapt<Staff>());
            await contexts.SaveChangesAsync();
        }

        public async Task DeleteStaff(Guid StaffId)
        {
            var staff = contexts.Staffs.FirstOrDefault(x => x.Id == StaffId);

            contexts.Staffs.Remove(staff);
            await contexts.SaveChangesAsync();
        }

        public async Task<List<Staff>> GetAllAsync()
        {
            var staffs = await contexts.Staffs.AsNoTracking().ToListAsync();

            return staffs;
        }

        public async Task<List<Employee>> GetAllEmplyeesByStaffId(Guid staffId)
        {
            var staffEmployees = contexts.EmployeeStaff.Where(es => es.StaffId == staffId).Select(es => es.Employee).ToList();

            return staffEmployees;
        }

        public async Task<Staff> GetStaffById(Guid staffId)
        {
            var staff = await contexts.Staffs.FirstOrDefaultAsync(x => x.Id == staffId);

            return staff;
        }
    }
}