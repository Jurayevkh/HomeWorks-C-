using System;
namespace API.CRUD
{
	public interface ICar
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public string Brand { get; set; }
		public double Price { get; set; }
	}
}

