namespace GymManagmentSystem.Entities
{
    public class Members:GymUser
    {
        public string? Photo { get; set; }
        public ICollection<MemberShip> GetMemberShips { get; set; } = new HashSet<MemberShip>();
    }
}
