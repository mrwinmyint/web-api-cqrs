using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost.Repository
{
    public class PostRepositoryFacade
        : IPostRepositoryFacade
    {
        private readonly IUserRepository _userRepository;
        private readonly IPostRepository _postRepository;

        public PostRepositoryFacade(IUserRepository userRepository,
            IPostRepository postRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
        }

        public User GetUser(int userId)
        {
            return _userRepository.Get(userId);
        }

        public void AddPost(Post post)
        {
            _postRepository.Add(post);
        }
    }
}
