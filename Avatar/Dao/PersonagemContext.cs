using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avatar.Dao
{
    public class PersonagemContext : DbContext
    {

        public PersonagemContext() : base("PersonagemContext")
        {

        }

        public DbSet<Personagem> Personagens { set; get; }
    }
}