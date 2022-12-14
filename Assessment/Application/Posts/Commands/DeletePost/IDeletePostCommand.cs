using Application.Posts.Commands.UpdatePost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Commands.DeletePost
{
    public interface IDeletePostCommand
    {
        void Execute(int id);
    }
}
