using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi.Service
{
    public class LogoutService
    {
        private SignInManager<IdentityUser<int>> _signInManager;

        public LogoutService(SignInManager<IdentityUser<int>> signInManager)
        {
            _signInManager = signInManager;
        }

        public Result DeslogaUsuario()
        {
            var resultadoIdendity = _signInManager.SignOutAsync();
            if(resultadoIdendity.IsCompletedSuccessfully) return Result.Ok();
            return Result.Fail("Logout falhou");
        }
    }
}
