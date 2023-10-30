using System;
using Npgsql;
using ADO.NET___third_lesson.Dtos;

namespace ADO.NET___third_lesson
{
    public class EmployeeService:IEmployeeService
	{
        public string connectionString = "Server=localhost;Port=5433;Database=crudEmployee;User Id=postgres;Password=20081403;";
        public void CreateEmployee(EmployeeDto employeeDto)
        {
            var Employee = new Employee()
            {
                Id=0,
                Name=employeeDto.Name,
                Surname=employeeDto.Surname,
                Email=employeeDto.Email,
                Login=employeeDto.Login,
                Password=employeeDto.Password,
                Status=employeeDto.Status,
                Role=employeeDto.Role,
                CreatedDate=DateTime.Now,
                UpdatedDate=DateTime.Now,
                DeletedDate=DateTime.Now,
            };
            using(NpgsqlConnection connection=new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = $"insert into employee() value({Employee.Id}, {Employee.Name}, {Employee.Surname}, {Employee.Email}, {Employee.Login}, {Employee.Password}, {Employee.Status}, {Employee.Role}, {Employee.CreatedDate}, {Employee.UpdatedDate}, {Employee.DeletedDate})";

                NpgsqlCommand command = new NpgsqlCommand(query,connection);

            }
        }
        
        public void UpdateEmployee(int Id, EmployeeDto employeeDto)
        {
        }

        public void DeleteEmployee(int Id)
        {

        }

        public void DeepDeleteEmployee(int id)
        {

        }

        public List<Employee> GetAll()
        {
            var employees = new List<Employee>();
            using (NpgsqlConnection connection=new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "select * from employee";

                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee()
                    {
                        Id = int.Parse(reader[0].ToString()),
                        Name = reader[1].ToString(),
                        Surname = reader[2].ToString(),
                        Email = reader[3].ToString(),
                        Login = reader[4].ToString(),
                        Password = reader[5].ToString(),
                        //(YourEnum)Enum.Parse(typeof(YourEnum), enumString);
                        Status = (status)Enum.Parse(typeof(status),reader[6].ToString()),
                        Role = (role)Enum.Parse(typeof(role),reader[7].ToString()),
                        CreatedDate = DateTime.Parse(reader[8].ToString()),
                        UpdatedDate = DateTime.Parse(reader[9].ToString()),
                        DeletedDate = DateTime.Parse(reader[10].ToString()),
                    };
                    
                    employees.Add(employee);
                }
            }
            return employees;
        }

        public Employee GetById (int Id)
        {

        }
    }
}

