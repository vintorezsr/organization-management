using OrganizationManagement.WebUI.Abstraction;
using OrganizationManagement.WebUI.Models.Enums;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class Employee : EntityBase<int>
    {
        public string? Nik { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Gender Gender { get; set; }
        public ICollection<EmployeePosition> Positions { get; set; } = new List<EmployeePosition>();
    }
}
