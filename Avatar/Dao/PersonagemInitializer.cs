using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avatar.Dao
{
    public class PersonagemInitializer : DropCreateDatabaseIfModelChanges<PersonagemContext>
    {

        protected override void Seed(PersonagemContext context)
        {
            var personagens = new List<Personagem>
            {
                new Personagem { Id = 1, Nome = "",Sexo = "M", Url = "https://image.shutterstock.com/image-vector/pixel-art-red-haired-warrior-600w-661627120.jpg",
                    Classe = new Classe {  NomeClasse = "Guerreiro", Destreza = 50, Forca = 100, Inteligencia = 200 }
               
                   

                }
            };
            
            personagens.ForEach(p => context.Personagens.Add(p));
            context.SaveChanges();
        }

    }
}