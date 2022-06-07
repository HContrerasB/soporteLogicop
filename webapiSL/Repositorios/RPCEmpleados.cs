using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiSL.Models;

namespace webapiSL.Repositorios
{
    public class RPCEmpleados
    {
        public static List<Empleado> _listaEmpleados = new List<Empleado>()
        {
            new Empleado() {IdEmpleado=1, Nombres = "Hector Fernando",Apellidos="Contreras Bolivar",Direccion="Kra 57A N 4B-90 ",Email="hectorfeboco@gmail.com",IdGenero=1,IdCiudad=1 },
         
        };

        public IEnumerable<Empleado> ObtenerEmpleados()
        {
            return _listaEmpleados;
        }

        public Empleado ObtenerEmpleado(int id)
        {
            var Empleado = _listaEmpleados.Where(cli => cli.IdEmpleado == id);

            return Empleado.FirstOrDefault();
        }

        public void Agregar(Empleado nuevoEmpleado)
        {
            _listaEmpleados.Add(nuevoEmpleado);
        }
    }
}
