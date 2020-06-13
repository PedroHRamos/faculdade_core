using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Feedback_facul.Service.UsuarioFolder;
using Feedback_facul.Model;
using Feedback_facul.DTO;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("login")]
    public class AuthController : ApiController
    {
        private readonly IUsuarioService _user = new UsuarioService();

        private Object createToken(string username, string id, string role)
        {
            string key = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw=="; //Secret key which will be used later during validation    
            var issuer = "http://mysite.com";  //normally this will be your site URL    

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            //permClaims.Add(new Claim("valid", "1"));
            permClaims.Add(new Claim("userid", id));
            permClaims.Add(new Claim(ClaimTypes.Name, username));  //PEGAR AS ROLES CORRETAS

            //Create Security Token object by giving required parameters    
            var token = new JwtSecurityToken(issuer, //Issure    
                            issuer,  //Audience    
                            permClaims,
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return new { data = jwt_token };
        }

        //[HttpPost]
        //public Object GetToken([FromBody] LoginDTO userRequest)
        [HttpPost]
        [Route("signin")]
        public Object Obter([FromBody] LoginDTO userRequest)
        {
            Usuario user = _user.Obter(userRequest.email, userRequest.password);
            if (user == null)
            {
                return new Exception("Usuário ou senha invalidos");
            }

            return createToken(user.email, user.id.ToString(), "Administrador");            
        }

        [HttpPost]
        [Route("create-account")]
        public Object SalvarAluno([FromBody] UsuarioDTO usuario)
        {
            if (_user.SalvarUsuario(usuario))
            {
                return createToken(usuario.email, usuario.senha, "Administrador");
            } else
            {
                return new Exception("Não foi possível cadastrar o usuário");
            }
        }

        [HttpPost]
        [Route("user-details")]
        public UsuarioDTO Obter([FromBody] int id)
        {
            return _user.ObterDetalhe(id);
        }

        //[HttpPost]
        //[Route("signout")]
        //public Object SalvarAluno([FromBody] UsuarioDTO usuario)
        //{
        //    if (_user.SalvarUsuario(usuario))
        //    {
        //        return createToken(usuario.email, usuario.senha, "Administrador");
        //    }
        //    else
        //    {
        //        return new Exception("Não foi possível cadastrar o usuário");
        //    }
        //}
    }
}