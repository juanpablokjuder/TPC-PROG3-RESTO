using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public Categoria categoria { get; set; }
        public string descripcion { get; set; }
        public string img { get; set; }


    }
}
