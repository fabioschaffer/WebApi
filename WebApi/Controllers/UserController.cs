using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2 {

    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserApp user) {
            // Recupera o usuário
            //var user = UserRepository.Get(model.Username, model.Password);

            // Verifica se o usuário existe
            //if (user == null)
            //    return NotFound(new { message = "Usuário ou senha inválidos" });


            if (user.Login == "adm") {

                // Gera o Token
                var token = TokenService.GenerateToken(user.Login);

                // Oculta a senha
                //user.Password = "";

                // Retorna os dados
                return new {
                    user = user,
                    token = token
                };
            } else {
                return null;
            }
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";


        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);


    }
}
