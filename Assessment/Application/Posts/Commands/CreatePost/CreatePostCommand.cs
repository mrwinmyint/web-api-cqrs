using Application.Posts.Commands.CreatePost.Factory;
using Application.Posts.Commands.CreatePost.Repository;
using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostCommand
        : ICreatePostCommand
    {
        private readonly IPostRepositoryFacade _respositories;
        private readonly IPostFactory _factory;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePostCommand(IPostRepositoryFacade respositories,
            IPostFactory factory,
            IUnitOfWork unitOfWork)
        {
            _respositories = respositories;
            _factory = factory;
            _unitOfWork = unitOfWork;
        }

        public void Execute(CreatePostModel model)
        {
            var user = _respositories
                .GetUser(model.UserId);

            if (user == null) 
            {
                throw new Exception("User not found");
            }

            var title = model.Title;

            var body = model.Body;

            var post = _factory.Create(
                user,
                title,
                body);

            _respositories.AddPost(post);

            _unitOfWork.Save();
        }
    }
}
