using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Envio
    {
        Producto producto { get; set; }
        Camion camion { get; set; }
        Fecha FechadeEnvio { get; set; }
        Cliente cliente { get; set; }
    }
}
