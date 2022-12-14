using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery
     : IGetPostDetailQuery
    {
        private readonly IPostRepository _repository;

        public GetPostDetailQuery(IPostRepository repository)
        {
            _repository = repository;
        }

        public PostDetailModel Execute(int postId)
        {
            var sale = _repository.GetAll()
                .Where(p => p.Id == postId)
                .Select(p => new PostDetailModel()
                {
                    Id = p.Id,
                    UserFullName = p.User != null 
                                    ? p.User.Name 
                                    : string.Empty,
                    Body = p.Body,
                    Title = p.Title
                })
                .SingleOrDefault();

            return sale;
        }
    }
}
