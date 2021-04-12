using ProjetoTccDoacaoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTccDoacaoDeSangue.Context
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DataContext")
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set;}

        public virtual DbSet<TipoSanguineo> TipoSanguineos { get; set; }
    }
}