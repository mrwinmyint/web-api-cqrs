using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.DeletePost.Repository
{
    public class DeletePostRepositoryFacade
        : IDeletePostRepositoryFacade
    {
        private readonly IPostRepository _postRepository;

        public DeletePostRepositoryFacade(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public Post GetPost(int postId)
        {
            return _postRepository.Get(postId);
        }

        public void DeletePost(Post post)
        {
            _postRepository.Remove(post);
        }
    }
}
