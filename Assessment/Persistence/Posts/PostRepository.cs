using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Posts;
using Assessment.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Posts
{
    public class PostRepository
    : Repository<Post>,
        IPostRepository
    {
        public PostRepository(IDatabaseContext database)
            : base(database) { }
    }
}
