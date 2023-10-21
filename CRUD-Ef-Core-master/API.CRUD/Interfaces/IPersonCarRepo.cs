using System;
namespace API.CRUD
{
	public interface IPersonCarRepo
	{
		public Task BuyCar(int CarId,int PersonId);
		public Task RemovePersonCar(int Id);
		public Task UpdatePersonCar(int Id, PersonCarDto pcDto);
	}
}

