using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaEstudantil.Data.Repository;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // Incluir interface
        private readonly UsuarioRepository _repoUsuario;

        public UsuarioController()
        {
            _repoUsuario = new UsuarioRepository();
        }

        // Incluir IActionResult e validações
        [HttpGet]
        public List<Usuario> Get([FromBody] string nome, int instituicao)
        {
            if (nome != null)
                return _repoUsuario.SelecionarPorNome(nome);

            if (instituicao != 0)
                return _repoUsuario.SelecionarPorInstituicao(instituicao);

            return _repoUsuario.SelecionarTudo();
        }
    }
}
