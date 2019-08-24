using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using UserStore.BLL.Services;
using Microsoft.AspNet.Identity;
using UserStore.BLL.Interfaces;
using System.Web.Mvc;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using UserStore.Utils;

[assembly: OwinStartup(typeof(UserStore.App_Start.Startup))]

namespace UserStore.App_Start
{
    public class Startup
    {
		private IUserService UserService { get; set; }

		public Startup()
		{
			NinjectModule registrations = new NinjectRegistrations();
			var kernel = new StandardKernel(registrations);
			kernel.Unbind<ModelValidatorProvider>();

			DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

			UserService = kernel.Get<IUserService>();
		}

		public void Configuration(IAppBuilder app)
        {

			app.CreatePerOwinContext<IUserService>(() => UserService);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}
