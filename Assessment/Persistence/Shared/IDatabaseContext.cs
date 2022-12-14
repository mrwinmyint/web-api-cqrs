using Assessment.Domain.Albums;
using Assessment.Domain.Common;
using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System.Data.Entity;

namespace Assessment.Persistence.Shared
{
    public interface IDatabaseContext
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Post> Posts { get; set; }
        
        IDbSet<Album> Albums { get; set; }
        
        IDbSet<Company> Companies { get; set; }
        IDbSet<Address> Addresses { get; set; }
        IDbSet<Geo> Geoes { get; set; }

        IDbSet<T> Set<T>() where T : class, IEntity;

        void Save();
    }
}