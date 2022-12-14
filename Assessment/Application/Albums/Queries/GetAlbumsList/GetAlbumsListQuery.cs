using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Albums.Queries.GetAlbumsList
{
    public class GetAlbumsListQuery : 
        IGetAlbumsListQuery
    {
        private readonly IAlbumRepository _repository;

        public GetAlbumsListQuery(IAlbumRepository repository)
        {
            _repository = repository;
        }

        public List<AlbumModel> Execute()
        {
            var albums = _repository.GetAll()
                .Select(p => new AlbumModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    UserId = p.User.Id,
                });

            return albums.ToList();
        }
    }
}
