using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Albums;
using Assessment.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Albums
{
    public class AlbumRepository 
        : Repository<Album>,
        IAlbumRepository
    {
        public AlbumRepository(IDatabaseContext database)
            : base(database) { }
    }
}
