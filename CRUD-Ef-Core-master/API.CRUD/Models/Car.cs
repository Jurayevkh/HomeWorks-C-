using System;
using System.ComponentModel.DataAnnotations;

namespace API.CRUD
{
	public class Car:ICar
	{
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public ICollection<PersonCar> personCars { get; set; }

    }
}

