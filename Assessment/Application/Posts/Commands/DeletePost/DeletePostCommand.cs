using Application.Posts.Commands.UpdatePost.Factory;
using Application.Posts.Commands.UpdatePost.Repository;
using Application.Posts.Commands.UpdatePost;
using Assessment.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Posts.Commands.DeletePost.Repository;

namespace Application.Posts.Commands.DeletePost
{
    public class DeletePostCommand 
        : IDeletePostCommand
    {
        private readonly IDeletePostRepositoryFacade _respositories;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePostCommand(IDeletePostRepositoryFacade respositories,
            IUnitOfWork unitOfWork)
        {
            _respositories = respositories;
            _unitOfWork = unitOfWork;
        }

        public void Execute(int id)
        {
            var currentPost = _respositories
                .GetPost(id);

            if (currentPost == null) 
            {
                throw new Exception("Post not found");
            }

            _respositories.DeletePost(currentPost);

            _unitOfWork.Save();
        }
    }
}
