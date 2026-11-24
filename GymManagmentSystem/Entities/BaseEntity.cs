namespace GymManagmentSystem.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
    }
}
