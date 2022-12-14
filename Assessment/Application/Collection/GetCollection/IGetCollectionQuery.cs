using Assessment.Application.Users.Queries.GetUserList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Collection.GetCollection
{
    public interface IGetCollectionQuery
    {
        List<CollectionModel> Execute();
    }
}
