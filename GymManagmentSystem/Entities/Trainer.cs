using GymManagmentSystem.Enum;

namespace GymManagmentSystem.Entities
{
    public class Trainer:GymUser
    {
        public DateTime HireDate { get; set; }
        public Special Special { get; set; }
        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
    }
}
