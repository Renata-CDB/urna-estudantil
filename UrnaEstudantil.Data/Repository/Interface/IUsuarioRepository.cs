using System;
using System.Collections.Generic;
using System.Text;
using UrnaEstudantil.Domain;

namespace UrnaEstudantil.Data.Repository.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        List<Usuario> SelecionarPorNome(string nome);
        List<Usuario> SelecionarPorInstituicao(int instituicao);
    }
}
