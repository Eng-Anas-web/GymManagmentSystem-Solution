namespace GymManagmentSystem.Entities
{
    public class MemberShip : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime  EndDate { get; set; }

        public int MembersId { get; set; }
        public Members Member { get; set; } = default!;

        public int PlainId { get; set; }
        public Plain Plain { get; set; } = default!;

        public string Status => StartDate > DateTime.Now ? "UpComing" : EndDate > DateTime.Now ? "Active" : "Expir";

    }
}
