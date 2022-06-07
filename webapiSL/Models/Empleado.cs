using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace webapiSL.Models
{
    public class Empleado
    {
        [Key]
        public decimal IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public decimal IdGenero { get; set; }
        public decimal IdCiudad { get; set; }
    }
}
