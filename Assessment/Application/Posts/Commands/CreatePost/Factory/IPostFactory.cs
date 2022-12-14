using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost.Factory
{
    public interface IPostFactory
    {
        Post Create(User user, string title, string body);
    }
}
