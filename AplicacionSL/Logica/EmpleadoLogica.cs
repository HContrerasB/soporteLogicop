using AplicacionSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSL.Logica
{
    public class EmpleadoLogica
    {

        public void insetar(Empleado modelo) {

            var modeloactual = new Empleado();
            modeloactual.Idempleado = modelo.Idempleado;
            modeloactual.nombres = modelo.nombres;
            modeloactual.Apellidos = modelo.Apellidos;
            modeloactual.Dirreccion = modelo.Dirreccion;
            modeloactual.Email = modelo.Email;
            modeloactual.Idgenero = modelo.Idgenero;
            modeloactual.IdCiudad = modelo.IdCiudad;
        }


    }
}