using Avatar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avatar.Dao
{
    public class ContaUsuarioContext : DbContext
        {

            public ContaUsuarioContext() : base("ContaUsuarioContext")
            {

            }

            public DbSet<ContaUsuario> ContasUsuarios { set; get; }
        
    }


    
}