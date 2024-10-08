using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiApplication.Models
{
    public class ProductoDeseado
    {
        public int ProductoDeseadoId { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
