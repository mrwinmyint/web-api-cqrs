using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Posts.Queries.GetPostsList
{
    public class GetPostsListQuery : 
        IGetPostsListQuery
    {
        private readonly IPostRepository _repository;

        public GetPostsListQuery(IPostRepository repository)
        {
            _repository = repository;
        }

        public List<PostModel> Execute()
        {
            var posts = _repository.GetAll()
                .Select(p => new PostModel
                {
                    Id = p.Id,
                    UserId = p.User.Id,
                    Title = p.Title,
                    Body = p.Body,
                });

            return posts.ToList();
        }
    }
}
