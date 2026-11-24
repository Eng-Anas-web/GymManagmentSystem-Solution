using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Configrations
{
    public class PlainConfigration : IEntityTypeConfiguration<Plain>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plain> builder)
        {
            builder.Property(x => x.createdAt).HasDefaultValueSql("GetDate()");
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("PlainDurationCheck", "DurationDays between 1 and 365");

            });
        }
    }
}
