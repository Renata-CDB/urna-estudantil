using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaEstudantil.Data.Repository;
using UrnaEstudantil.Data.Repository.Interface;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // Incluir interface
        private readonly IUsuarioRepository _repoUsuario;

        public UsuarioController(IUsuarioRepository repoUsuario)
        {
            _repoUsuario = repoUsuario;
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

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
           return _repoUsuario.Selecionar(id); 

        }

        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            _repoUsuario.Incluir(usuario);
        }

        [HttpPut]
        public Usuario Put(int id, [FromBody]Usuario usuario)
        {
            return _repoUsuario.Alterar(usuario);
        }

        [HttpDelete("{id}")] 
        public void Delete(int id)
        {
            var usuario = _repoUsuario.Selecionar(id);

            _repoUsuario.Excluir(usuario);
        }
    }

}
