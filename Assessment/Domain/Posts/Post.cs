using System;
using Assessment.Domain.Common;
using Assessment.Domain.Users;

namespace Assessment.Domain.Posts
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
