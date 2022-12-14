using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class BaseController : ApiController
    {
        // it's missing or invalid the server response must be a 501
        private const HttpStatusCode NotImplementedErrorCode = HttpStatusCode.NotImplemented;
        private const HttpStatusCode ClientErrorCode = HttpStatusCode.BadRequest;

        protected virtual void Authorize()
        {
            var authorizationHeader = Request.Headers.Authorization;
            if (authorizationHeader == null ||
                authorizationHeader.Scheme != "Bearer" ||
                authorizationHeader.Parameter != "af24353tdsfw")
            {
                throw new HttpResponseException(
                    Request.CreateErrorResponse(NotImplementedErrorCode, "Your request is not supported"));
            }            
        }

        protected virtual void ShowError(string message)
        {
            throw new HttpResponseException(
                    Request.CreateErrorResponse(ClientErrorCode, message));
        }
    }
}