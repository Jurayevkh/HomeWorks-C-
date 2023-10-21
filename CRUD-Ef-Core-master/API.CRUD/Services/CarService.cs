using System;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;

namespace API.CRUD
{
    public class CarService : ICarRepository
    {
        private readonly DataContext context;
        public CarService(DataContext context)
        {
            this.context = context;
        }
        public async Task AddCarAsync(CarDto carDto)
        {
            var car = new Car()
            {
                Model = carDto.Model,
                Brand = carDto.Brand,
                Price = carDto.Price
            };
            await context.Cars.AddAsync(car);
            await context.SaveChangesAsync();
        }

        public async Task<Car> GetCarByIdAsync(int Id)
        {
            var car = await context.Cars.FirstOrDefaultAsync(c=>c.Id==Id);
            return car;
        }
        public async Task<List<Car>> GetAllAsync()
        {
            var cars = await context.Cars.ToListAsync();
            return cars;
        }
        public async Task UpdateCarAsync(int Id, string Model, string Brand, double price)
        {
            var car = await context.Cars.FirstOrDefaultAsync(c => c.Id == Id);

            car.Model = Model;
            car.Brand = Brand;
            car.Price = price;

            context.Cars.Update(car);
            await context.SaveChangesAsync();
        }
        public async Task DeleteCar(int Id)
        {
            var car = await context.Cars.FirstOrDefaultAsync(c => c.Id == Id);

            if (car != null)
            {
                context.Cars.Remove(car);
                await context.SaveChangesAsync();
            }
        }

    }
}

