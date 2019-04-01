using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using projeto_lista.Entities;
using projeto_lista.Services;

namespace projeto_lista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTokenController : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly UsuarioService _userService;

        public JWTokenController(IConfiguration configuration, UsuarioService userService) {
            _configuration = configuration;
            _userService = userService;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            _userService.Add(usuario);

            Console.WriteLine(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.Id }, usuario);
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult ResquestToken([FromBody] Usuario request) {

            var user = _userService.GetV(request.email, request.senha);
            Console.WriteLine("teste de token");

            if (request.email == user.email && request.senha == user.senha) {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, request.email)
                };

                // recebe uma instancia da classe SymmetricSecurityKey 
                // armazenando a chave de criptografia usada na criação do token
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));

                // recebe um objeto do tipo SigninCredentials contendo a chave de 
                // criptografia e o algoritmo de segurança empregadoss na geração 
                // de assinaturas digitais para tokens
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "anderson.rl.tr@gmail.com",
                    audience: "anderson.rl.tr@gmail.com",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );
               
                return Ok(
                    new { user.Id, user.email, user.senha , token = new JwtSecurityTokenHandler().WriteToken(token)}
                );
            }
            return BadRequest("Credenciais invalidas...");
        }
        
    }
}