using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class OrganizationUnit : EntityBase<int>
    {
        public int? ParentId { get; set; }
        public int UnitTypeId { get; set; }
        public string? Name { get; set; }
        public UnitType? UnitType { get; set; }
        public OrganizationUnit? Parent { get; set; }
        public ICollection<OrganizationUnit> Childs { get; set; } = new List<OrganizationUnit>();
        public ICollection<Position> Positions { get; set; } = new List<Position>();
    }
}
