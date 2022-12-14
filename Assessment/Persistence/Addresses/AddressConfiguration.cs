using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Addresses
{
    public class AddressConfiguration 
        : EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Street)
                .HasMaxLength(150);

            Property(p => p.Suite)
                .HasMaxLength(150);

            Property(p => p.City)
                .HasMaxLength(50);

            Property(p => p.Zipcode)
                .HasMaxLength(50);

            HasRequired(p => p.Geo);
        }
    }
}
