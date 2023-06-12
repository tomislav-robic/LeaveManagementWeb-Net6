using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "de83dff9-333b-4598-b87b-b53f284e1174",
                    UserId = "dd77dee8-333b-4598-b44b-b513284e1174"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "de83dee7-338b-4558-baab-b53f284e1174",
                    UserId = "cc99dee8-333b-4598-b44b-b513284e1174"
                }
            );
        }
    }
}