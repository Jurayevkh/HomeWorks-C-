namespace Services.Dtos
{
    public class EmployeeDtos
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Guid CompanyId { get; set; }
    }
}
