using Assessment.Domain.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.DeletePost.Repository
{
    public interface IDeletePostRepositoryFacade
    {
        Post GetPost(int postId);
        void DeletePost(Post post);
    }
}
