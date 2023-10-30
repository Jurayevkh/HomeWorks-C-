using System;
using ADO.NET___third_lesson.Dtos;

namespace ADO.NET___third_lesson
{
	public interface IEmployeeService
	{
		public void CreateEmployee(EmployeeDto employeeDto);
		public void UpdateEmployee(int Id,EmployeeDto employeeDto);
		public void DeleteEmployee(int Id);
		public void DeepDeleteEmployee(int id);
		public List<Employee> GetAll();
		public Employee GetById(int Id);
	}
}

