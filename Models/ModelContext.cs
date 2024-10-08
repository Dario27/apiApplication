using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiApplication.Models
{
    public class ModelContext:DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<ProductoDeseado> ProductosDeseados { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}