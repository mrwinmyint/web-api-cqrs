using Assessment.Application.Interfaces.Persistence;
using Assessment.Domain.Users;
using Assessment.Persistence.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Persistence.Users
{
    public class UserRepository
    : Repository<User>,
        IUserRepository
    {
        public UserRepository(IDatabaseContext database)
            : base(database) { }
    }
}
