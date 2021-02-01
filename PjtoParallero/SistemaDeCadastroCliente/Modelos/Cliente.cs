using System;
using System.Collections.Generic;

namespace Modelos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<Contatos> Contatos { get; set; }
    }
}
