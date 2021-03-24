using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avatar.Models
{
    public class ContaUsuario
    {

        public  int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool StatusConta { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Personagem Personagem { get; set; }
        public int IdPersonagem { get; set; }

        public List<Personagem> ListaPersonagem; // atenção

    }
}