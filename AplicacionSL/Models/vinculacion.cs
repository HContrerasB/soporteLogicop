using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSL.Models
{
    public class vinculacion
    {
        public decimal Idvinculacion { get; set; }
        public decimal idempleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Idcargo { get; set; }
        public DateTime fechaRetiro { get; set; }
        public DateTime FechaRegistro { get; set; }



    }
}