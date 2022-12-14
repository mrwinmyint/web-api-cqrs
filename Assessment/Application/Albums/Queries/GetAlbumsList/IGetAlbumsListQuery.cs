using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Albums.Queries.GetAlbumsList
{
    public interface IGetAlbumsListQuery
    {
        List<AlbumModel> Execute();
    }
}
