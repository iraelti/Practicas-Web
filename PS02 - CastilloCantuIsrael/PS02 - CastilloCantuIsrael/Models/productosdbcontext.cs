using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS02.CastilloCantu.Models
{
    public class productosdbcontext:DbContext
    {
        public productosdbcontext() : base("MyConnection")
        {
        }
        public DbSet<productos> Productos { get; set; }
    }
}