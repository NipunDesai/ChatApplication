using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using ChatApplication.Controllers;
using ChatApplication.DataRepository;
using ChatApplication.Repository;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

namespace ChatApplication
{
    public class IocConfig
    {

        public static void RegisterDependencies()
        {

            var builder = new ContainerBuilder();

            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(ChatController).Assembly);


            builder.RegisterType<ChatRepository>().As<IChatRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterGeneric(typeof(DataRepository<>)).As(typeof(IDataRepository<>));

            IContainer container = builder.Build();
          //  DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
          }
    }
}