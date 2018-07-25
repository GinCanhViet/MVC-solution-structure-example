using GBlog.Service.Data;
using GBlog.DAL.Infrastructure;
using GBlog.DAL.Repositories;
using GBlog.DAL.UnitOfWork;
using StructureMap;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace GBlog
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        private ObjectFactory objectFactory;
        public StructureMapControllerFactory()
        {
            objectFactory = new ObjectFactory();
            objectFactory.Initialize<ControllerRegistry>();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)objectFactory.Container.GetInstance(controllerType);
        }

    }
    class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            //Scan(scan => {
            //    scan.TheCallingAssembly();
            //    scan.WithDefaultConventions();
            //});
            For<IUnitOfWork>().Use<UnitOfWork>();
            For<IConnectionFactory>().Use<ConnectionFactory>();            
            For<IPostService>().Use<PostService>();
            For<IPostRepository>().Use<PostRepository>();
        }
    }
}