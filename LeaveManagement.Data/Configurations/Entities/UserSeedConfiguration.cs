using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            _ = builder.HasData(
                new Employee
                {
                    Id = "dd77dee8-333b-4598-b44b-b513284e1174",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(user: null, password: "Admin123!"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "cc99dee8-333b-4598-b44b-b513284e1174",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "User123!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}