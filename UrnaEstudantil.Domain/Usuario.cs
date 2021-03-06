using System;
using UrnaEstudantil.Domain.Interface;

namespace UrnaEstudantil.Domain
{
    public class Usuario : IBaseEntity
    {
        public int Id { get; set; }
        public int Instituicao { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string RA { get; set; }
        public string Senha { get; set; }
        public  PerfilEnum Perfil { get; set; }

    }
}
