using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.CreatePost
{
    public class CreatePostModel
    {
        public int UserId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }
    }
}
