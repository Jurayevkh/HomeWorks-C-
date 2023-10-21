using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
        public class Staff
        {
            [Key]
            public Guid Id { get; set; }
            public string Name { get; set; }
            public ICollection<EmployeeStaff> EmployessStaff { get; set; }
        }
}