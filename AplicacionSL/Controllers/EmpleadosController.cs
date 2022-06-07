using AplicacionSL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AplicacionSL.Controllers
{
    public class EmpleadosController : Controller
    {

        // GET: Empleados
        public ActionResult Index()
        {
            // List<Empleado> lst = new List<Empleado>();

            // Models.DB.Empleado empleado = new Models.DB.Empleado();
            List<Empleado> lstEmp = new List<Empleado>();
            using (var BDEmpleado = new Models.DB.UsuarioContext())
            {

                var lst = (from d in BDEmpleado.Empleado
                           select new Empleado
                           {
                               Idempleado = d.IdEmpleado,
                               nombres = d.Nombres,
                               Apellidos = d.Apellidos,
                               Dirreccion = d.Direccion,
                               Email =d.Email,
                              Idgenero=d.IdGenero,
                              IdCiudad=d.IdCiudad

                              
                           }).ToList();
                foreach (var item in lst)
                {
                    lstEmp.Add(item);
                }

            }

            return View(lstEmp);
        }

    }
}