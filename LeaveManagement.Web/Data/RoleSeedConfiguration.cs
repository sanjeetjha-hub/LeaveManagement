using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
      
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {

                    Id: "a6577c66-0673-45d5-99f4-cdfb03065021",

                }
             ) ;
               
        }
    }
}









//Id: "a6577c66-0673-45d5-99f4-cdfb03065021",
                //    Name: "Administrator",
                 //   NormalizedName: "Administrator"