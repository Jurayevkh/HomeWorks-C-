using System;
using Microsoft.EntityFrameworkCore;

namespace API.CRUD
{
	public class DataContext:DbContext
	{

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonCar> PersonCars { get; set; }
    }
}

