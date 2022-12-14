[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(WebApi.App_Start.NinjectWebCommon), "Stop")]

namespace WebApi.App_Start
{
    using System;
    using System.Web;
    using Assessment.Application.Albums.Queries.GetAlbumsList;
    using Assessment.Application.Interfaces.Persistence;
    using Assessment.Application.Posts.Queries.GetPostsList;
    using Assessment.Application.Users.Queries.GetUserList;
    using Assessment.Persistence.Shared;
    using Assessment.Persistence.Users;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Assessment.Persistence.Albums;
    using Assessment.Persistence.Posts;
    using Application.Posts.Commands.CreatePost;
    using Application.Posts.Commands.CreatePost.Repository;
    using Application.Posts.Commands.CreatePost.Factory;
    using Application.Posts.Commands.UpdatePost.Factory;
    using Application.Posts.Commands.UpdatePost.Repository;
    using Application.Posts.Commands.UpdatePost;
    using Application.Posts.Commands.DeletePost;
    using Application.Posts.Commands.DeletePost.Repository;
    using Application.Collection.GetCollection;
    using Application.Posts.Queries.GetPostDetail;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load modules or register services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IDatabaseContext>().To<DatabaseContext>().InRequestScope();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

            kernel.Bind<IPostFactory>().To<PostFactory>().InRequestScope();
            kernel.Bind<IPostRepositoryFacade>().To<PostRepositoryFacade>().InRequestScope();
            kernel.Bind<IUpdatePostFactory>().To<UpdatePostFactory>().InRequestScope();
            kernel.Bind<IUpdatePostRepositoryFacade>().To<UpdatePostRepositoryFacade>().InRequestScope();
            kernel.Bind<IDeletePostRepositoryFacade>().To<DeletePostRepositoryFacade>().InRequestScope();

            kernel.Bind<IPostRepository>().To<PostRepository>().InRequestScope();
            kernel.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            kernel.Bind<IAlbumRepository>().To<AlbumRepository>().InRequestScope();

            kernel.Bind<IGetPostsListQuery>().To<GetPostsListQuery>().InRequestScope();
            kernel.Bind<IGetPostDetailQuery>().To<GetPostDetailQuery>().InRequestScope();
            kernel.Bind<IGetUsersListQuery>().To<GetUsersListQuery>().InRequestScope();
            kernel.Bind<IGetAlbumsListQuery>().To<GetAlbumsListQuery>().InRequestScope();
            kernel.Bind<IGetCollectionQuery>().To<GetCollectionQuery>().InRequestScope();

            kernel.Bind<ICreatePostCommand>().To<CreatePostCommand>().InRequestScope();
            kernel.Bind<IUpdatePostCommand>().To<UpdatePostCommand>().InRequestScope();
            kernel.Bind<IDeletePostCommand>().To<DeletePostCommand>().InRequestScope();
        }
    }
}