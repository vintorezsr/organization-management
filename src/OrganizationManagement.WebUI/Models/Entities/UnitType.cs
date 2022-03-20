using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class UnitType : EntityBase<int>
    {
        public string? Name { get; set; }
        public short Level { get; set; }
        public ICollection<OrganizationUnit> OrganizationUnits { get; set; } = new List<OrganizationUnit>();
    }
}
