using Application.Posts.Commands.CreatePost;
using Application.Posts.Commands.CreatePost.Factory;
using Application.Posts.Commands.CreatePost.Repository;
using Application.Posts.Commands.UpdatePost.Factory;
using Application.Posts.Commands.UpdatePost.Repository;
using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand
        : IUpdatePostCommand
    {
        private readonly IUpdatePostRepositoryFacade _respositories;
        private readonly IUpdatePostFactory _factory;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePostCommand(IUpdatePostRepositoryFacade respositories,
            IUpdatePostFactory factory,
            IUnitOfWork unitOfWork)
        {
            _respositories = respositories;
            _factory = factory;
            _unitOfWork = unitOfWork;
        }

        public void Execute(UpdatePostModel model)
        {
            var currentPost = _respositories
                .GetPost(model.Id);

            if (currentPost == null) 
            {
                throw new Exception("Post not found");
            }

            var user = _respositories
                .GetUser(model.UserId);

            if (user == null) 
            {
                throw new Exception("User not found");
            }

            var title = model.Title;

            var body = model.Body;

            _factory.Update(currentPost,
                user,
                title,
                body);

            _unitOfWork.Save();
        }
    }
}
