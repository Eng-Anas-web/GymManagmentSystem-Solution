using GymManagmentSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Configrations
{
    public class MemberConfigration : GymUserConfigration<Members>, IEntityTypeConfiguration<Members>
    {
        public new void Configure(EntityTypeBuilder<Members> builder)
        {
            builder.Property(x => x.createdAt).HasColumnName("JoinDate").HasDefaultValueSql("GetDate()");
            base.Configure(builder);
        }
    }
}
