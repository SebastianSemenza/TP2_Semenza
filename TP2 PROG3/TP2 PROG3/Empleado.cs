using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Empleado : Persona
    {
        Categoria cat { get; set; }
        Sueldo sueldo { get; set; }
        Turno turno { get; set; }
        Puesto puesto { get; set; }
        Fecha fechaIngreso { get; set; }
    }
}
