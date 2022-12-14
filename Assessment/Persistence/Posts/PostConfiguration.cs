using Assessment.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Posts
{
    public class PostConfiguration 
        : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Body)
                .IsRequired()
                .HasMaxLength(500);

            Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(p => p.User);
        }
    }
}
