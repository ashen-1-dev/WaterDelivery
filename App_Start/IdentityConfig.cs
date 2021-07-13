using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using WaterDelivery.Models;

namespace WaterDelivery.App_Start
{
        public class IdentityConfig
        {
            public void Configuration(IAppBuilder app)
            {
                app.CreatePerOwinContext(() => new DeliveryContext());
                app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
                app.CreatePerOwinContext<RoleManager<Role>>((options, context) =>
                    new RoleManager<Role>(
                        new RoleStore<Role>(context.Get<DeliveryContext>())));

                app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Home/Login"),
                });
            }
        }
}