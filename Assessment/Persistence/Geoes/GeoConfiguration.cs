using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Geoes
{
    public class GeoConfiguration
    : EntityTypeConfiguration<Geo>
    {
        public GeoConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Lat)
                .IsRequired();

            Property(p => p.Lng)
                .IsRequired();
        }
    }
}
