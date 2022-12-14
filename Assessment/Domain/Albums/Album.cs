using System;
using System.Collections.Generic;
using Assessment.Domain.Common;
using Assessment.Domain.Users;

namespace Assessment.Domain.Albums
{
    public class Album : IEntity
    {
        public int Id { get; set; }

        public User User { get; set; }

        public string Title { get; set; }
        
    }
}
