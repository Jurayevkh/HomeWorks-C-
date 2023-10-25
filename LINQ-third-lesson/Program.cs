using LINQ;
using LINQ_third_lesson;

//var groupJoin = Student1.GetAllTeachers().GroupJoin(Student1.GetAllStudents(),
//                                teacher => teacher.Talim_shakli,
//                                student => student.Talim_shakli,     //innerKeySelector
//                                (parent, child) => new // resultSelector 
//                                {
//                                    student = child,
//                                    teacher = parent.Talim_shakli,
//                                    teachername=parent.FirstName,
//                                });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine($"Teacher: {item.teachername} {item.teacher}");

//    foreach (var stud in item.student)
//        Console.WriteLine($"Student Name: {stud.FirstName} {stud.Talim_shakli}");
//}


//HomeWork:

HomeWork.RunMyHomeWork();

Console.ReadLine();