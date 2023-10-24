using LINQ_Second_Lesson;


//var students = Student.GetAllStudents().OrderBy(x => x.Id).ThenBy(z => z.Contract).ThenBy(y=>y.LastName);

//foreach(var student in students)
//{
//    Console.WriteLine($"{student.Id} {student.FirstName} {student.Contract}");
//}


//var students = Student.GetAllStudents().OrderBy(x => x.FirstName)
//                                        .ThenByDescending(y => y.Course)
//                                        .ThenBy(z => z.Contract)
//                                        .ThenByDescending(a => a.Age);

//foreach (var student in students)
//{
//    Console.WriteLine($"{student.FirstName} {student.Course} {student.Contract} {student.Age}");
//}

//var students = from student in Student.GetAllStudents()
//               orderby student.FirstName ascending, student.Course descending, student.Contract ascending, student.Age ascending
//               select student;
//foreach (var student in students)
//{
//    Console.WriteLine($"{student.FirstName} {student.Course} {student.Contract} {student.Age}");
//}


//var students = Student.GetAllStudents().Any(x => x.sirtqimi == true);

//Console.WriteLine(students);

//var students1 = Student.GetAllStudents().Where(x => x.sirtqimi == true & x.Course > 4);

//foreach (var student in students1)
//{
//    Console.WriteLine($"{student.FirstName} {student.Course} {student.Contract} {student.Age}");
//}


//Console.ReadLine();


//HomeWork:
HomeWork.RunMyHomeWorks();

Console.ReadLine();