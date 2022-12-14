using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Users.Queries.GetUserList
{
    public interface IGetUsersListQuery
    {
        List<UserModel> Execute();
    }
}
