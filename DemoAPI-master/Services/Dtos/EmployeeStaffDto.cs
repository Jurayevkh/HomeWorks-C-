using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;


namespace Services.Dtos
{
    public class EmployeeStaffDto
    {
        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(Staff))]
        public Guid StaffId { get; set; }
        public Employee Employee { get; set; }
        public Staff Staff { get; set; }
    }
}
