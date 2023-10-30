using System;
namespace ADO.NET___third_lesson.Dtos
{
	public class EmployeeDto:IEmployeeDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public status Status { get; set; }
		public role Role { get; set; }
	}
}

