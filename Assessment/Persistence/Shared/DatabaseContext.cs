using Assessment.Domain.Albums;
using Assessment.Domain.Common;
using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using Assessment.Persistence.Addresses;
using Assessment.Persistence.Albums;
using Assessment.Persistence.Companies;
using Assessment.Persistence.Geoes;
using Assessment.Persistence.Posts;
using Assessment.Persistence.Users;
using System.Data.Entity;

namespace Assessment.Persistence.Shared
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public IDbSet<User> Users { get; set; }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Geo> Geoes { get; set; }

        public DatabaseContext() : base("Assessment")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public new IDbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new AlbumConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new CompanyConfiguration());
            modelBuilder.Configurations.Add(new GeoConfiguration());
        }
    }
}
