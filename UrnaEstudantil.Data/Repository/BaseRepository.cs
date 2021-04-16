using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrnaEstudantil.Data.Repository.Interface;
using UrnaEstudantil.Domain.Interface;

namespace UrnaEstudantil.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
    {
        protected readonly UrnaEstudantilContexto _contexto;

        public BaseRepository(UrnaEstudantilContexto contexto)
        {
            _contexto = contexto;
        }

        public virtual List<T> SelecionarTudo()
        {
            return _contexto.Set<T>().ToList();
        }

        public virtual T Selecionar(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Incluir(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public virtual T Alterar(T entity)
        {
            var resposta = Selecionar(entity.Id);
            if (resposta == null)
                return null;

            _contexto.Entry(resposta).CurrentValues.SetValues(entity);
            _contexto.SaveChanges();

            return entity;
        }

        public void Excluir(T entity)
        {
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
