using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.UpdatePost.Factory
{
    public interface IUpdatePostFactory
    {
        Post Update(Post post, User user, string title, string body);
    }
}
