using System;
namespace API.CRUD
{
	public interface IPerson
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
	}
}

