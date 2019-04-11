using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Cliente : Empresa
    {
        TipoCliente tipo { get; set; }
        ComprasDeClientes compra { get; set; }
        Fecha fechaRegistro { get; set; }
    }
}
