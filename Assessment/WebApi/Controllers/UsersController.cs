using Assessment.Application.Posts.Queries.GetPostsList;
using Assessment.Application.Users.Queries.GetUserList;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class UsersController : BaseController
    {
        // GET: Users
        private readonly IGetUsersListQuery _query;

        public UsersController(IGetUsersListQuery query)
        {
            _query = query;
        }

        public IHttpActionResult Get()
        {
            Authorize();

            return Ok(_query.Execute());
        }
    }
}