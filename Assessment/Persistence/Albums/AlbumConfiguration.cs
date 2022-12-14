using Assessment.Domain.Albums;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Albums
{
    public class AlbumConfiguration : 
        EntityTypeConfiguration<Album>
    {
        public AlbumConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(250);

            HasRequired(p => p.User);
        }
    }
}
