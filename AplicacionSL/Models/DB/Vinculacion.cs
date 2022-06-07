using System;
using System.Collections.Generic;

namespace AplicacionSL.Models.DB
{
    public partial class Vinculacion
    {
        public decimal Idvinculacion { get; set; }
        public decimal IdEmpleado { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public decimal? Idcargo { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
