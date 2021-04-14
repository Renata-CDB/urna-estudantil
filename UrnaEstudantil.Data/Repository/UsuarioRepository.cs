using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        //public UsuarioRepository(UrnaEstudantilContexto contexto) : base(contexto) { }

        public List<Usuario> SelecionarPorNome(string nome)
        {
            var usuarios = _contexto.Usuarios.Where(x => x.Nome.Contains(nome))
                .ToList();
            return usuarios;
        }

        public List<Usuario> SelecionarPorInstituicao(int instituicao)
        {
            var usuarios = _contexto.Usuarios.Where(x => x.Instituicao.Equals(instituicao))
                .ToList();
            return usuarios;
        }
    }
}
