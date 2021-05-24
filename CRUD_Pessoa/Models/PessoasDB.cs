using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_Pessoa.Models
{
    public class PessoasDB : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}