using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Posts.Queries.GetPostsList
{
    public interface IGetPostsListQuery
    {
        List<PostModel> Execute();
    }
}
