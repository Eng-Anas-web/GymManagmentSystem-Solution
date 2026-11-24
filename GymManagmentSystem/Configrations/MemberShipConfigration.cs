using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configrations
{
    public class MemberShipConfigration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(x => x.createdAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(m => m.Plain).WithMany(p => p.MemberShips).HasForeignKey(m => m.PlainId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
