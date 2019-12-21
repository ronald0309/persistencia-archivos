﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNA.Cheques
{
    class Cheque
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Receptor { get; set; }
        public string Institucion { get; set; }
        public string Moneda { get; set; }

    }
}
