using System;
namespace API.CRUD
{
	public interface IPersonCar
	{
		public int Id { get; set; }
		public int PersonId { get; set; }
		public int CarId { get; set; }
	}
}

