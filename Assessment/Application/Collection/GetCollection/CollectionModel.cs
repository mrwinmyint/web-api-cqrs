using Assessment.Application.Albums.Queries.GetAlbumsList;
using Assessment.Application.Posts.Queries.GetPostsList;
using Assessment.Application.Users.Queries.GetUserList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collection.GetCollection
{
    public class CollectionModel
    {
        public PostModel Post { get; set; }
        public AlbumModel Album { get; set; }
        public UserModel User { get; set; }
    }
}
