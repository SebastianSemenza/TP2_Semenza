using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_PROG3
{
    class Empresa
    {
        string cuit { get; set; }
        string razonSocial { get; set; }
        Dueño dueño { get; set; }
        Pais pais { get; set; }
        Provincia provincia { get; set; }
        Localidad loc { get; set; }
        string direccion { get; set; }
    }
}
