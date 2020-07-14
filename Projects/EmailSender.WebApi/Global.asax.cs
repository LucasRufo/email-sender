using EmailSender.Biz.Core;
using EmailSender.Biz.Interface;
using EmailSender.Biz.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using System.Web.Mvc;

namespace EmailSender.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var container = new Container();
            container.Register<IEmailRepository, EmailRepository>();
            container.Register<IEmailService, EmailService>();
            container.Register<IAnexoService, AnexoService>();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}
