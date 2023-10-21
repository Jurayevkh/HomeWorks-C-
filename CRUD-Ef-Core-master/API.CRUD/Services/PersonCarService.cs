using System;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace API.CRUD
{
	public class PersonCarService:IPersonCarRepo
	{
        private readonly DataContext context;
        public PersonCarService(DataContext context)
        {
            this.context = context;
        }

        public async Task BuyCar(int CarId, int PersonId)
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == PersonId);
            var car = await context.Cars.FirstOrDefaultAsync(c => c.Id == CarId);
            var pc = new PersonCar()
            {
                PersonId = person.Id,
                CarId = car.Id,
            };

            await context.PersonCars.AddAsync(pc);
            await context.SaveChangesAsync();
        }
        public async Task RemovePersonCar(int Id)
        {
            var pc = await context.PersonCars.FirstOrDefaultAsync(p => p.Id == Id);

            if (pc != null)
            {
                context.PersonCars.Remove(pc);
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdatePersonCar(int Id, PersonCarDto pcDto)
        {
            var pc = await context.PersonCars.FirstOrDefaultAsync(p => p.Id == Id);

            pc.PersonId = pcDto.PersonId;
            pc.CarId = pcDto.CarId;

            context.PersonCars.Update(pc);
            await context.SaveChangesAsync();
        }

    }
}

