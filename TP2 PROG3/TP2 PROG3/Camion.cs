using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Camion : Vehiculo
    {
        Acoplado acoplado;
        TipoCamion tipo { get; set; }
        MarcaCamion marca { get; set; }
    }
}
