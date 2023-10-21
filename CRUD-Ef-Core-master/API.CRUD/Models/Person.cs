using System;
using System.ComponentModel.DataAnnotations;

namespace API.CRUD
{
	public class Person
	{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public ICollection<PersonCar> personCars { get; set; }
    }
}

