using Assessment.Domain.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Interfaces.Persistence
{
    public interface IAlbumRepository : IRepository<Album>
    {
    }
}
