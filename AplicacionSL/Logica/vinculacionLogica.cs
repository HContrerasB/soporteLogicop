using AplicacionSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionSL.Logica
{
    public class vinculacionLogica
    {
        public void insetar(vinculacion modelo)
        {

            var modeloactual = new vinculacion();
            modeloactual.Idvinculacion = modelo.Idvinculacion;
            modeloactual.idempleado = modelo.idempleado;
            modeloactual.FechaIngreso = modelo.FechaIngreso;
            modeloactual.Idcargo = modelo.Idcargo;
            modeloactual.fechaRetiro = modelo.fechaRetiro;
            modeloactual.FechaRegistro = modelo.FechaRegistro;
          
        }
    }
}