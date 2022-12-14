using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Posts.Queries.GetPostDetail
{
    public class PostDetailModel
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
