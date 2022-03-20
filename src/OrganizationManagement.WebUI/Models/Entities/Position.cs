using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class Position : EntityBase<int>
    {
        public int OrganizationUnitId { get; set; }
        public int JobId { get; set; }
        public string? Name { get; set; }
        public Job? Job { get; set; }
        public OrganizationUnit? OrganizationUnit { get; set; }
        public ICollection<EmployeePosition> Employees { get; set; } = new List<EmployeePosition>();
    }
}
