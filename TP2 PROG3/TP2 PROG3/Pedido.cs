using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Pedido : Tarea
    {
        TipoPedido tipo { get; set; }
        Camion camion { get; set; }
        Producto producto { get; set; }
        Deposito deposito { get; set; }
        Envio envio { get; set; }
        Fecha fechaPedido { get; set; }
    }
}
