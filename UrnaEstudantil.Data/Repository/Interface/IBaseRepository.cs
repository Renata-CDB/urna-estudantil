using System;
using System.Collections.Generic;
using System.Text;
using UrnaEstudantil.Domain.Interface;

namespace UrnaEstudantil.Data.Repository.Interface
{
    public interface IBaseRepository<T> where T: class, IBaseEntity
    {
        List<T> SelecionarTudo();
        T Selecionar(int id);
        void Incluir(T entity);
        T Alterar(T entity);
        void Excluir(T entity);
        void Dispose();
    }
}
