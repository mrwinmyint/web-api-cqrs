using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Queries.GetPostDetail
{
    public interface IGetPostDetailQuery
    {
        PostDetailModel Execute(int id);
    }
}
