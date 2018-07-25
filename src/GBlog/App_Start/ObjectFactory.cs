using StructureMap;
using System;
using System.Threading;

namespace GBlog
{
    public class ObjectFactory

    {
        private readonly Lazy<Container> _containerBuilder =
            new Lazy<Container>(() => new Container(), LazyThreadSafetyMode.ExecutionAndPublication);

        public IContainer Container
        {
            get { return _containerBuilder.Value; }
        }
        //public void ConfigureContainer(ServiceConfigurationContext context)
        //{
        //    context.Container.Configure(ConfigureContainer);

        //    // This will setup the DependencyResolver with the EPiServer StructureMap Container
        //    DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
        //}

        public void Initialize<TEntity>() where TEntity : Registry, new()
        {
            Container.Configure(x =>
            {
                x.AddRegistry<TEntity>();
            });
        }
    }
}