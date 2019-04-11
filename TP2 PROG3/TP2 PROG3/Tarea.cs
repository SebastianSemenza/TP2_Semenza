using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Tarea
    {
        TipoTarea tipo { get; set; }
        string nombre { get; set; }
        Turno turno { get; set; }
        Empleado empleado { get; set; }
        Maquina maquina { get; set; }
        Deposito deposito { get; set; }
    }
}
