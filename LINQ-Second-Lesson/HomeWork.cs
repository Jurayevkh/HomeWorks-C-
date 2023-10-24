using System;
namespace LINQ_Second_Lesson
{
	public class HomeWork
	{
		public static void RunMyHomeWorks()
		{
			//Homework 1
			Console.WriteLine("HomeWork 1:");
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
			var query1 = from num in numbers
						 where num % 2 == 0
						 select num;
			foreach (var item in query1)
			{
				Console.WriteLine($" {item} ");
			}

			//HomeWork 2
			Console.WriteLine("\nHomeWork 2:");
			List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 34, 56, 86, 112, 12 };
			var query2 = from num2 in numbers2
						 where num2 >= 1 & num2 <= 11
						 select num2;

			foreach (var item in query2)
			{
				Console.WriteLine($" {item} ");
			}

			//HomeWork 3
			Console.WriteLine("\nHomeWork 3:");
			List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
			var query3 = from num3 in numbers3
						 select new
						 {
							 number = num3,
							 squareOfNumber = Math.Pow(num3, 2),
						 };

			foreach (var item in query3)
			{
				Console.WriteLine($"Raqam: {item.number} Kvadrati: {item.squareOfNumber}");
			}

			//HomeWork 4
			Console.WriteLine("\nHomeWork 4:");
			List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 1, 4, 6, 8 };
			var query4 = numbers4.GroupBy(num => num);
			foreach (var item in query4)
			{
				Console.WriteLine($"{item.Key} soni {item.Count()} marta qatnashgan");
			}

			//HomeWork 5
			Console.WriteLine("\nHomeWork 5:");
			string word = "apple";
			var query5 = word.GroupBy(character => character);
			foreach (var item in query5)
			{
				Console.WriteLine($"{item.Key} harfi {item.Count()} marta qatnashgan");
			}

			//HomeWork 6
			Console.WriteLine("\nHomeWork 6:");
			List<string> daysOfWeek = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
			var query6 = from day in daysOfWeek
						 select day;

			foreach (var item in query6)
			{
				Console.WriteLine(item);
			}

			//HomeWork 7
			Console.WriteLine("\nHomeWork 7:");
			List<int> numbers5 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 1, 4, 6, 8 };
			var query7 = numbers5.GroupBy(num => num);
			foreach (var item in query7)
			{
				Console.WriteLine($"{item.Key} {item.Key*item.Count()} {item.Count()}");
			}

			//HomeWork 8
			Console.WriteLine("\nHomeWork 8:");
			List<string> cities = new List<string> {"ROME", "LONDON", "NAIROB", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
			var query8 = from city in cities
						 where city.StartsWith("P") & city.EndsWith("S")
						 select city;
			foreach(var item in query8)
			{
				Console.WriteLine(item);
			}

			//HomeWork 9

			Console.WriteLine("\nHomeWork 9:");
			List<int> numbers6 = new List<int> { 55, 200, 740 ,76, 230 ,482, 95 };
			var query9 = from num in numbers6
						 where num > 80
						 select num;
			foreach(var item in query9)
			{
				Console.WriteLine(item);
			}

			//HomeWork 10

			Console.WriteLine("\nHomeWork 10:");
            var numbers7 = new List<int>();
			Console.Write("Input the number of members on the List: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
				Console.Write($"Member {i}: ");
                numbers7.Add(Convert.ToInt32(Console.ReadLine()));
            }
			Console.Write("Input the value above you want to display the members of the List :");
            int aboveNum = Convert.ToInt32(Console.ReadLine());

			var query10 = from num in numbers7
						  where num > aboveNum
						  select num;

            foreach (var item in query10)
            {
                Console.WriteLine(item);
            }
        }
	}
}

