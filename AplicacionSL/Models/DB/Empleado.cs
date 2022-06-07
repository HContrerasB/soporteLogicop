using System;
using System.Collections.Generic;

namespace AplicacionSL.Models.DB
{
    public partial class Empleado
    {
        public Empleado()
        {
            Vinculacion = new HashSet<Vinculacion>();
        }

        public decimal IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public decimal? IdGenero { get; set; }
        public decimal? IdCiudad { get; set; }

        public virtual ICollection<Vinculacion> Vinculacion { get; set; }
    }
}
