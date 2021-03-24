using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avatar.Dao
{
    public class ContaUsuarioInitializer : DropCreateDatabaseIfModelChanges<ContaUsuarioContext>
    {

        protected override void Seed(ContaUsuarioContext context)
        {
            var contaUsuarios = new List<ContaUsuario>
            {

               new ContaUsuario{ Id = 1, Email = "fernando@gmail.com", 
                   StatusConta = false, Senha = "1234", NomeUsuario = "Fernando", IdPersonagem = 1, DataCriacao = DateTime.Now,
                   ListaPersonagem = new List<Personagem> { } }

            };


            contaUsuarios.ForEach(x => context.ContasUsuarios.Add(x));
            context.SaveChanges();
        }

    }
}