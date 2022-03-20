using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class Job : EntityBase<int>
    {
        public int JobFamilyId { get; set; }
        public string? Name { get; set; }
        public JobFamily? JobFamily { get; set; }
        public ICollection<Position> Positions { get; set; } = new List<Position>();
    }
}
