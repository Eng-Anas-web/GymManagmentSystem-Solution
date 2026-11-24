using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configrations
{
    public class SessionConfigration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.createdAt).HasDefaultValueSql("GetDate()");
            builder.HasOne( x => x.Trainer).WithMany(t => t.Sessions).HasForeignKey( x=> x.TrainerId).OnDelete(DeleteBehavior.Restrict );
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("SessionCapacityConstrain", "Capacity between 1 and 25");
                t.HasCheckConstraint("SessionEndDateAfterStartDate", "EndDate > StartDate");

            });
        }
    }
}
