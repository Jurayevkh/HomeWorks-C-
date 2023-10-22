using System;
namespace LINQ
{
	public class Employee
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set;}
		public int Age { get; set; }
		public float Salary { get; set; }
		public string? Position { get; set; }
		public List<string> ProgrammingLanguages { get; set; }
		public List<string> Educations { get; set; }
		public List<string> Skills { get; set; }

		public static List<Employee> GetEmployees()
		{
			List < Employee > employees= new List<Employee>()
			{
				new Employee
				{
					Id=1, FirstName="Rustambek",LastName="Jo'rayev", Age=15,Salary=10000, Position="TeamLead",
					ProgrammingLanguages=new List<string>{ "C","Python","C#","JavaScript"} ,
					Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
					Skills=new List<string>{"Work with OOP","EF core"},
				},
				new Employee
				{
					Id=2, FirstName="Nurmuhammad",LastName="Sharobiddinov",Age=20,Salary=2000,Position="Middle",
					ProgrammingLanguages=new List<string>{ "C","Python","C#","C++"},
                    Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
                    Skills=new List<string>{"Work with OOP","EF core"},
                },
				new Employee
				{
					Id=3,FirstName="Sevinch",LastName="Xayriddinova",Age=19,Salary=2100,Position="Middle",
					ProgrammingLanguages=new List<string>{ "C","Python","C#","C++","Pascal"},
					Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
                    Skills=new List<string>{"Work with OOP","EF core"},
                },
				new Employee
				{
					Id=4,FirstName="Bahriddin",LastName="Abdusalomov",Age=20,Salary=2000,Position="Middle",
					ProgrammingLanguages=new List<string>{ "C","Python","C#","C++"},
                    Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
                    Skills=new List<string>{"Work with OOP","EF core"},
                },
				new Employee
				{
					Id=5,FirstName="Muhammad Abdulloh",LastName="Komilov",Age=23,Salary=2500,Position="Senior",
					ProgrammingLanguages=new List<string>{ "C","Python","C#","JavaScript","TypeScript","Rust"},
                    Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
                    Skills=new List<string>{"Work with OOP","EF core"},
                },
				new Employee
				{
					Id=6,FirstName="John",LastName="Doe",Age=23,Salary=50,Position="Junior",
					ProgrammingLanguages=new List<string>{ "Python"},
                    Educations=new List<string>{"Najot Ta'lim","MyTeacher"},
                    Skills=new List<string>{"Work with OOP","EF core"},
                }
			};

            return employees;
		}
	}
}

