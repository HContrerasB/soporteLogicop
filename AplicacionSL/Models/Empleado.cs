using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSL.Models
{
    public class Empleado
    {
        public decimal Idempleado { get; set; }
        public string nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dirreccion { get; set; }
        public string Email { get; set; }
        public decimal? Idgenero { get; set; }
        public decimal? IdCiudad { get; set; }
    }
}