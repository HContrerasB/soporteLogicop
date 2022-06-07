using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapiSL.Models
{
    public class Vinculacion
    {
        [Key]
        public decimal Idvinculacion { get; set; }
        public decimal IdEmpleado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Idcargo { get; set; }
        public DateTime FechaRetiro { get; set; }
        public DateTime FechaRegistro { get; set; }
       
    }
}
