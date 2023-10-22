using System;
namespace LINQ
{
	public class Queries
	{
		public static void Run()
		{
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			var query = numbers.Where(x => x % 2 == 0).ToList();

			foreach(var number in query)
			{
				Console.WriteLine(number);
			}
		}

		public static void SelectWithCondition()
		{
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			List<int> query = (from x in numbers
							   where x % 2 == 0
							   select x).ToList();

			foreach(var number in query)
			{
				Console.WriteLine(number);
			}

		}

		public static void SelectWithMixed()
		{
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			List<int> query = (from x in numbers
							   select x).Where(x => x % 2 == 0).ToList();

			foreach(var number in query)
			{
				Console.WriteLine(number);
			}
        }
	}
}

