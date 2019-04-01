using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using projeto_lista.Services;
using projeto_lista.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace projeto_lista.Controllers
{
    [Route("api/[controller]")]
    [Authorize()]
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly UsuarioService _userService; 

        public UsuariosController(UsuarioService userService) {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get() {
            return _userService.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetUsuario")]
        public ActionResult<Usuario> Get(string email, string senha) {
            var user = _userService.GetV(email, senha);

            if (user == null){
                return NotFound();
            }

            return user;
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Autenticar([FromBody] Usuario users) {
            Usuario user = _userService.Autenticar(users.nome, users.senha);

            if (user == null)
               return Unauthorized();
               
            return new ObjectResult(user);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest();
            }

            _userService.Add(usuario);

            Console.WriteLine(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.email }, usuario);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, [FromBody] Usuario user) {

            if (user == null || user.Id != id){
                return BadRequest();
            }

            var u = _userService.GetV(user.email, user.senha);
            if (u == null){
                return NotFound();
            }

            u.email = user.email;
            u.senha = user.senha;
            _userService.Update(id,u);

            return NoContent();
        }

         [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id){
            var usuario = _userService.Get(id);

            if (usuario == null)
                return NotFound();

            _userService.Remove(id);

             return NoContent();
        }
    }
}