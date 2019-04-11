using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Proveedor : Empresa
    {
        TipoProveedor tipo { get; set; }
        CompraRealizadaAProv compras { get; set; }
        Fecha fechaAltaProv { get; set; }
    }
}
