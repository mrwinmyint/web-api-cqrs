using Assessment.Application.Albums.Queries.GetAlbumsList;
using Assessment.Application.Users.Queries.GetUserList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class AlbumsController : BaseController
    {
        // GET: Albums
        private readonly IGetAlbumsListQuery _query;

        public AlbumsController(IGetAlbumsListQuery query)
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