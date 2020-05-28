using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using Feedback_facul.DTO;
using Feedback_facul.Service.UsuarioFolder;

namespace Feedback_facul.core.Controllers
{
    [RoutePrefix("usuario")]
    public class UsuarioController : ApiController
    {
        private readonly IUsuarioService usuarioService = new UsuarioService();

        [Route("usuario")]
        [HttpPost]
        public void SalvarAluno([FromBody] UsuarioDTO usuario)
        {
            usuarioService.SalvarUsuario(usuario);
        }

        //[Route("cadastrar")]
        //[HttpPost]
        //public bool Cadastrar([FromBody] LoginDTO login)
        //{
        //    //return usuarioService.Cadastrar(login);
        //    var user = new Usuario { UserName = login.Email, Email = login.Email };
        //    var result = _userManager.CreateAsync(user, login.Senha);

        //    if (result.Result.Succeeded)
        //    {
        //        _signInManager.SignInAsync(user, isPersistent: false);
        //        _signInManager.UserManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Aluno"));
        //        return true;
        //    }
        //    else throw result.Exception;
        //    // usuarioService.SalvarUsuario(usuario);
        //}

        ////[Route("login")]
        ////[HttpPost]
        ////public bool Logar([FromBody] LoginDTO login)
        ////{
        ////    var result = _signInManager.PasswordSignInAsync(login.Email, login.Senha, false, lockoutOnFailure: false);
        ////    if (result.Result.Succeeded)
        ////    {
        ////        return true;
        ////    }
        ////    //if (result.RequiresTwoFactor)
        ////    //{
        ////    //    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
        ////    //}
        ////    if (result.Result.IsLockedOut)
        ////    {
        ////        return false;
        ////    }
        ////    else
        ////    {
        ////        throw result.Exception;
        ////    }
        ////}
    }
}