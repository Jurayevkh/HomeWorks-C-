using LINQ;

//CLASS WORK:

//Queries.Run();

//Console.WriteLine();

//Queries.SelectWithCondition();

//Console.WriteLine();

//Queries.SelectWithMixed();

//Console.WriteLine();

//Console.ReadLine();


//var employeeSalary = from salary in Employee.GetEmployees()
//                     select (salary.FirstName, salary.Position, salary.Salary * 12);

//foreach (var employee in employeeSalary)
//    Console.WriteLine(employee);

//var mostRichEmployee = (from salary in Employee.GetEmployees()
//                        orderby salary.Salary descending
//                        select (salary.FirstName, salary.Salary)).Take(1);

//foreach (var employee in mostRichEmployee)
//{
//    Console.WriteLine(employee);
//}

//var mostPoorEmployee = (from salary in Employee.GetEmployees()
//                        orderby salary.Salary ascending
//                        select (salary.FirstName, salary.Salary)).Take(1);

//foreach (var employee in mostPoorEmployee)
//{
//    Console.WriteLine(employee);
//}

//var employeesAndTheirPLanguage= (from emp in Employee.GetEmployees()
//                                 from programLanguage in emp.ProgrammingLanguages
//                                 select new
//                                 {
//                                     EmployeeName = emp.FirstName,
//                                     PLanguage = programLanguage
//                                 }).ToList();

//foreach(var employee in employeesAndTheirPLanguage)
//{
//    Console.WriteLine(employee.EmployeeName + "=>" + employee.PLanguage);
//}





//HOMEWORK:

var employees = (from emp in Employee.GetEmployees()
                 from programmingLanguage in emp.ProgrammingLanguages
                 from educations in emp.Educations
                 from skills in emp.Skills
                 select new
                 {
                     EmployeeName=emp.FirstName,
                     EmployeeLastName=emp.LastName,
                     EmployeeAge=emp.Age,
                     EmloyeeSalary=emp.Salary,
                     EmployeePosition=emp.Position,
                     PLanguage=programmingLanguage,
                     Educations=educations,
                     Skills=skills
                 }).ToList();

foreach(var employee in employees)
{
    Console.WriteLine(employee);
}

Console.ReadLine();