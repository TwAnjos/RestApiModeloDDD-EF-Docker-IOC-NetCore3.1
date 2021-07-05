using System;

namespace RestApiModeloDDD.Domain.Entitys
{
    public class Cliente : Base
    {
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
