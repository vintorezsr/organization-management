using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class EmployeePosition : EntityBase<int>
    {
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public int Staffing { get; set; } = 100;
        public Employee? Employee { get; set; }
        public Position? Position { get; set; }
    }
}
