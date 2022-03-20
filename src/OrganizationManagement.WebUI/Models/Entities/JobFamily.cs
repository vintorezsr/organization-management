using OrganizationManagement.WebUI.Abstraction;

namespace OrganizationManagement.WebUI.Models.Entities
{
    public class JobFamily : EntityBase<int>
    {
        public string? Name { get; set; }
        public bool Chief { get; set; }
        public int Level { get; set; }
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
