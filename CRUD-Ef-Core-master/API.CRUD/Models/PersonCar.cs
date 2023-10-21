using System;
using System.ComponentModel.DataAnnotations;

namespace API.CRUD
{
	public class PersonCar
	{
        [Key]
        public int Id { get; set; }

        public int PersonId { get; set; }
        public Person person { get; set; }

        public int CarId { get; set; }
        public Car car { get; set; }
    }
}

