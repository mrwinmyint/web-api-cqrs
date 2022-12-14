using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Users
{
    public class UserConfiguration
        : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Username)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Phone)
                .HasMaxLength(50);

            Property(p => p.Website)
                .HasMaxLength(250);

            HasRequired(p => p.Address);

            HasRequired(p => p.Company);
        }
    }
}
