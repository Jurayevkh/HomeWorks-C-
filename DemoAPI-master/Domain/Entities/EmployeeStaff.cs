
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class EmployeeStaff
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(Staff))] 
        public Guid StaffId { get; set; }
        public Employee Employee { get; set; }
        public Staff Staff { get; set; }
    }
}
