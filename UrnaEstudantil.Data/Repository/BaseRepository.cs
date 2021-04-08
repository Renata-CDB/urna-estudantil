using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UrnaEstudantil.Data.Repository
{
    public class BaseRepository<T> where T : class
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
    }
}
