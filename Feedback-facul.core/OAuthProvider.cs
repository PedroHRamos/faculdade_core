using Feedback_facul.Model;
using Feedback_facul.Service.UsuarioFolder;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Feedback_facul.core
{
    public class OAuthProvider : OAuthAuthorizationServerProvider
    {
        private readonly IUsuarioService _usuario = new UsuarioService();
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            return Task.Factory.StartNew(() => 
            {
                string username = context.UserName;
                string password = Regex.Replace(context.Password, @"[\f\n\r\t\v]", "");
                //string password = JObject.Parse(context.Password); ;
                

                Usuario user = _usuario.Obter(username, password);

                if(user != null)
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.nome),
                        new Claim("UserId", user.id.ToString()),
                        //new Claim(ClaimTypes.Role, user.Role)
                    };

                    ClaimsIdentity OAuthIdentity = new ClaimsIdentity(claims, Startup.OAuthOptions.AuthenticationType);

                    context.Validated(new Microsoft.Owin.Security.AuthenticationTicket(OAuthIdentity, new Microsoft.Owin.Security.AuthenticationProperties() { }));

                } else
                {
                    context.SetError("error", "Usuário não encontrado");
                }
            });
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            if (context.ClientId == null)
            {
                context.Validated();
            }
            return Task.FromResult<object>(null);
        }
    }
}