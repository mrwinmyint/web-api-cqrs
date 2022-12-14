using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Companies
{
    public class CompanyConfiguration
        : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Name)
                .HasMaxLength(150);

            Property(p => p.CatchPhrase)
                    .HasMaxLength(250);

            Property(p => p.Bs)
                    .HasMaxLength(150);
        }
        
    }
}
