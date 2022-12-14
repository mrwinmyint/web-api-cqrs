using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.UpdatePost.Repository
{
    public class UpdatePostRepositoryFacade 
        : IUpdatePostRepositoryFacade
    {
        private readonly IUserRepository _userRepository;
        private readonly IPostRepository _postRepository;

        public UpdatePostRepositoryFacade(IUserRepository userRepository,
            IPostRepository postRepository)
        {
            _userRepository = userRepository;
            _postRepository = postRepository;
        }

        public Post GetPost(int postId)
        {
            return _postRepository.Get(postId);
        }

        public User GetUser(int userId)
        {
            return _userRepository.Get(userId);
        }
    }
}
