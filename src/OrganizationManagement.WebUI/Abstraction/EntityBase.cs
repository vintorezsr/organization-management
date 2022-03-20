namespace OrganizationManagement.WebUI.Abstraction
{
    public abstract class EntityBase<T>
        where T : struct
    {
        public T Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
