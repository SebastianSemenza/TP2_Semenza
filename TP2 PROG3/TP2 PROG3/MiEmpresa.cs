using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    public class MiEmpresa : Empresa
    {
        Deposito deposito { get; set; }
        Empleado empleado { get; set; }
        Producto producto { get; set; }
        Maquina maquina { get; set; }
        Vehiculo vehiculo { get; set; }
        Tarea tarea { get; set; }
        Pedido pedido { get; set; }
    }
}
