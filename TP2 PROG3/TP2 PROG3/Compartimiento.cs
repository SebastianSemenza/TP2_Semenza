using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Compartimiento
    {
        public int tamaño { get; set; }
        public int cantidadMax { get; set; }
        Producto producto { get; set; }
        Stock stock { get; set; }
    }
}
