using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Mesa
    {
        public int id { get; set; }
        public int numeroMesa { get; set; }
        public string descripcion { get; set; }
        public List<int>meseros { get; set; }

    }
}
