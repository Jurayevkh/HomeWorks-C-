using System;
namespace LINQ_third_lesson
{
	public class HomeWork
	{
		public static void RunMyHomeWork()
		{
			//HomeWork 11
			Console.WriteLine("HomeWork 11: ");
			List<int> numbers = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
			Console.Write("N ni kiriting: ");
			int n = int.Parse(Console.ReadLine());
			var query11 = (from num in numbers
						   orderby num descending
						   select num).Take(n);
			foreach (var item in query11)
			{
				Console.WriteLine(item);
			}

			//HomeWork 12:
			Console.WriteLine("\nHomeWork 12:");
			List<string> words = new List<string> { "assalom", "alaykum", "DASTURGA", "xush", "KELIBSIZ" };
			var query12 = words.Where(word => (int)word[0] < 90).ToList();

			foreach (var item in query12)
			{
				Console.WriteLine(item);
			}

			//HomeWork 13:
			Console.WriteLine("\nHomeWork 13:");
			var words2 = new List<string>();
			Console.Write("Input number of strings to store in the array: ");
			int countOfstrings = Convert.ToInt32(Console.ReadLine());

			for (int a = 0; a < countOfstrings; a++)
			{
				Console.Write($"Member {a}: ");
				words2.Add(Console.ReadLine());
			}
			var query13 = words2.Aggregate((s1, s2) => s1 + " " + s2);
			Console.WriteLine(query13);

			//HomeWork 14:
			Console.WriteLine("\nHomeWork 14:");
			List<int> numbers2 = new List<int> { 1, 2, 3, 45, 64, 244, 622, 345, 145, 903, 125, 342, 526, 346 };
			Console.Write("Nechta son olmoqchisiz");
			int n1 = int.Parse(Console.ReadLine());
			var query14 = (from num in numbers2
						   orderby num
						   select num).Take(n1);
			foreach (var item in query14)
			{
				Console.WriteLine(item);
			}

			//HomeWork 15:
			Console.WriteLine("\nHomeWork 15:");
			List<string> files = new List<string> { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
			var query15 = files.GroupBy(file => file.Split('.')[1].ToLower());

			foreach (var item in query15)
			{
				Console.WriteLine($"{item.Count()} Files with .{item.Key} extension");
			}

			//HomeWork 17:
			Console.WriteLine("\nHomeWork 17:");
			var words3 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Word: ");
			var word = Console.ReadLine();
			words3.Remove(word);

			foreach (var item in words3)
			{
				Console.WriteLine(item);
			}

			//HomeWork 18:
			Console.WriteLine("\nHomeWork 18:");
			var words4 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Word: ");
			var word1 = Console.ReadLine();
			words4.Remove(words4.Find(word => string.Equals(word, word1)));

			foreach (var item in words4)
			{
				Console.WriteLine(item);
			}

			//HomeWork 19:
			Console.WriteLine("\nHomeWork 19:");
			var words5 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Word: ");
			var word2 = Console.ReadLine();
			words5.RemoveAll(word => word == word2);

			foreach (var item in words5)
			{
				Console.WriteLine(item);
			}

			//HomeWork 20
			Console.WriteLine("\nHomeWork 20:");
			var words6 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Index: ");
			int i = int.Parse(Console.ReadLine());
			words6.RemoveAt(i - 1);

			foreach (var item in words6)
			{
				Console.WriteLine(item);
			}

			//HomeWork 21
			Console.WriteLine("\nHomeWork 21:");
            var words7 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Index: ");
			int index = int.Parse(Console.ReadLine());
			for(int b=0; b < index+1; b++)
			{
				words7.RemoveAt(b);
			}

            foreach (var item in words7)
            {
                Console.WriteLine(item);
            }

			//HomeWork 22:
			Console.WriteLine("\nHomeWork 22:");
			var words8 = new List<string>() { "salom", "assalom", "hayr", "yaxshi", "zo'r", "nega" };
			Console.Write("Input the min: ");
			int min = int.Parse(Console.ReadLine());
			var query16 = from word4 in words8
						  where word4.Length > min
						  select word;

            foreach (var item in query16)
            {
                Console.WriteLine(item);
            }

			
        }
    }
}

