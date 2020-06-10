using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(Feedback_facul.core.Startup))]

namespace Feedback_facul.core
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        public void Configuration(IAppBuilder app)
        {      
            app.UseOAuthBearerTokens(OAuthOptions);
        }

        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {                
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/login"),
                Provider = new OAuthProvider()
            };
        }
    }
}
