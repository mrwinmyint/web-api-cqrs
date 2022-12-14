using Assessment.Application.Albums.Queries.GetAlbumsList;
using Assessment.Application.Interfaces.Persistence;
using Assessment.Application.Posts.Queries.GetPostsList;
using Assessment.Application.Users.Queries.GetUserList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collection.GetCollection
{
    public class GetCollectionQuery
    : IGetCollectionQuery
    {
        private readonly IUserRepository _userRepository;
        private readonly IPostRepository _postRepository;
        private readonly IAlbumRepository _albumRepository;

        public GetCollectionQuery(IUserRepository userRepository,
            IPostRepository postRepository,
            IAlbumRepository albumRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
            _albumRepository = albumRepository;
        }

        public List<CollectionModel> Execute()
        {
            var users = GetUsers();

            var posts = GetPosts().ToArray();

            var albums = GetAlbums().ToArray();

            var collectionList = GetCollection(users, posts, albums);

            return collectionList;
        }

        private IEnumerable<UserModel> GetUsers()
        {
            var users = _userRepository.GetAll()
                        .OrderBy(p => Guid.NewGuid())
                        .Select(p => new UserModel()
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Username = p.Username,
                            Address = new AddressModel()
                            {
                                Street = p.Address.Street,
                                City = p.Address.City,
                                Suite = p.Address.Suite,
                                Zipcode = p.Address.Zipcode,
                                Geo = new GeoModel()
                                {
                                    Lat = p.Address.Geo.Lat,
                                    Lng = p.Address.Geo.Lng,
                                }
                            },
                            Email = p.Email,
                            Phone = p.Phone,
                            Website = p.Website,
                            Company = new CompanyModel()
                            {
                                Name = p.Company.Name,
                                CatchPhrase = p.Company.CatchPhrase,
                                Bs = p.Company.Bs,
                            }
                        });

            return users;
        }

        private IEnumerable<PostModel> GetPosts()
        {
            var posts = _postRepository.GetAll()
                .OrderBy(p => Guid.NewGuid())
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    UserId = p.User.Id,
                    Title = p.Title,
                    Body = p.Body,
                }).Take(30);

            return posts;
        }

        private IEnumerable<AlbumModel> GetAlbums()
        {
            var albums = _albumRepository.GetAll()
                .OrderBy(p => Guid.NewGuid())
                .Select(p => new AlbumModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    UserId = p.User.Id,
                }).Take(30);

            return albums;
        }

        private List<CollectionModel> GetCollection(IEnumerable<UserModel> users,
            PostModel[] posts,
            AlbumModel[] albums)
        {
            List<CollectionModel> collectionList = new List<CollectionModel>();
            for (int i = 0; i < posts.Count(); i++)
            {
                var post = posts[i];
                var album = albums[i];
                var userId = post.UserId;
                var user = users.Where(u => u.Id == post.UserId).FirstOrDefault();
                var collection = new CollectionModel()
                {
                    Post = post,
                    User = user,
                    Album = album
                };
                collectionList.Add(collection);
            }

            return collectionList;
        }
    }
}
