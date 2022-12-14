using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Albums.Queries.GetAlbumsList
{
    public class AlbumModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }
    }
}
