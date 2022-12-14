using Assessment.Domain.Posts;
using Assessment.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost.Factory
{
    public class PostFactory : IPostFactory
    {
        public Post Create(User user, string title, string body)
        {
            var post = new Post
            {
                User = user,
                Title = title,
                Body = body
            };
            return post;
        }
    }
}
