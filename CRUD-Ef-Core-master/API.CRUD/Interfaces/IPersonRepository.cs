using System;
namespace API.CRUD
{
	public interface IPersonRepository
	{
        public Task AddPersonAsync(PersonDto personDto);
        public Task<Person> GetPersonByIdAsync(int Id);
        public Task<List<Person>> GetAllAsync();
        public Task UpdatePersonAsync(int Id, string Name, string Address, string Email);
        public Task DeletePerson(int Id);
    }
}

