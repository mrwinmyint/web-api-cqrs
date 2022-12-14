using Application.Posts.Commands.CreatePost;
using Application.Posts.Commands.DeletePost;
using Application.Posts.Commands.UpdatePost;
using Application.Posts.Queries.GetPostDetail;
using Assessment.Application.Posts.Queries.GetPostsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace WebApi.Controllers
{
    public class PostsController : BaseController
    {
        // GET: Posts
        private readonly IGetPostsListQuery _query;
        private readonly IGetPostDetailQuery _detailQuery;
        private readonly ICreatePostCommand _createCommand;
        private readonly IUpdatePostCommand _updateCommand;
        private readonly IDeletePostCommand _deleteCommand;

        public PostsController(IGetPostsListQuery query,
            IGetPostDetailQuery detailQuery,
            ICreatePostCommand createCommand,
            IUpdatePostCommand updateCommand,
            IDeletePostCommand deleteCommand)
        {
            _query = query;
            _detailQuery = detailQuery;
            _createCommand = createCommand;
            _updateCommand = updateCommand;
            _deleteCommand = deleteCommand;
        }

        public IHttpActionResult Get()
        {
            Authorize();

            return Ok(_query.Execute());
        }

        public IHttpActionResult Get(int id)
        {
            Authorize();

            var post = _detailQuery.Execute(id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(_detailQuery.Execute(id));
        }

        [HttpPost]
        public HttpResponseMessage Create(CreatePostModel post)
        {
            Authorize();

            try
            {
                _createCommand.Execute(post);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        [HttpPut]
        public HttpResponseMessage Update(UpdatePostModel post)
        {
            Authorize();

            try
            {
                _updateCommand.Execute(post);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }            

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public HttpResponseMessage Delete([FromUri] int id)
        {
            Authorize();

            try
            {
                _deleteCommand.Execute(id);
            }
            catch(Exception ex) 
            {
                ShowError(ex.Message);
            }

            return new HttpResponseMessage(HttpStatusCode.NoContent);
        }
    }
}