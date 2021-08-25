using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // Admin
                    RoleId = "71698054-b32d-4f19-be01-51f75ff92b62",
                    UserId = "dd67e19c-be82-4195-be73-4f4f0de7a85c"
                }, 
                new IdentityUserRole<string>
                {
                    // User
                    RoleId = "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                    UserId = "3a247e3a-fea1-4df7-8410-tdef62de1052"
                }
            );
        }
    }
}
