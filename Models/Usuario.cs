using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiApplication.Models
{
    public class Usuario
    {
        public string UsuarioId { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoDeseado> ProductosDeseados { get; set; }
    }
}
