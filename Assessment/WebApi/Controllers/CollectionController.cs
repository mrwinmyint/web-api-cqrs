using Application.Collection.GetCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class CollectionController : BaseController
    {
        // GET: Collection
        private readonly IGetCollectionQuery _query;

        public CollectionController(IGetCollectionQuery query)
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