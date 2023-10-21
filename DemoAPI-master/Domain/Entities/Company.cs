﻿using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Employee> Employess { get; set; }
    }
}