using Application.Posts.Commands.CreatePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.UpdatePost
{
    public interface IUpdatePostCommand
    {
        void Execute(UpdatePostModel model);
    }
}
