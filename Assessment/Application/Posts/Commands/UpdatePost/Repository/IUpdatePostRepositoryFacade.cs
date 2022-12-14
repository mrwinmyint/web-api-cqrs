using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.UpdatePost.Repository
{
    public interface IUpdatePostRepositoryFacade
    {
        Post GetPost(int postId);
        User GetUser(int userId);
    }
}
