using System;
using Microsoft.EntityFrameworkCore;

namespace API.CRUD
{
	public class PersonService:IPersonRepository
	{
        private readonly DataContext context;
        public PersonService(DataContext context)
        {
            this.context = context;
        }

        public async Task AddPersonAsync(PersonDto personDto)
        {
            var person = new Person()
            {
                Name = personDto.Name,
                Address = personDto.Address,
                Email = personDto.Email
            };
            await context.Persons.AddAsync(person);
            await context.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int Id)
        {
            var person = await context.Persons.FindAsync(Id);
            return person;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            var persons = await context.Persons.ToListAsync();
            return persons;
        }

        public async Task UpdatePersonAsync(int Id, string Name, string Address, string Email)
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == Id);

            person.Name = Name;
            person.Address = Address;
            person.Email = Email;

            context.Persons.Update(person);
            await context.SaveChangesAsync();
        }
        public async Task DeletePerson(int Id)
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == Id);

            if (person != null)
            {
                context.Persons.Remove(person);
                await context.SaveChangesAsync();
            }
        }
    }
}

