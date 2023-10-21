using System;
namespace API.CRUD
{
	public interface ICarRepository
	{
		public Task AddCarAsync(CarDto carDto);
		public Task<Car> GetCarByIdAsync(int Id);
		public Task<List<Car>> GetAllAsync();
		public Task UpdateCarAsync(int Id, string Model, string Brand, double price);
		public Task DeleteCar(int Id);
	}
}

