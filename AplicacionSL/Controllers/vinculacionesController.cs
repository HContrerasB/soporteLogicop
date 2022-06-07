using AplicacionSL.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionSL.Controllers
{
    public class vinculacionesController : Controller
    {
        // GET: vinculaciones
        public ActionResult Index()
        {
            // List<Empleado> lst = new List<Empleado>();

            // Models.DB.Empleado empleado = new Models.DB.Empleado();
            List<Vinculacion> lstEmp = new List<Vinculacion>();
            using (var BDEmpleado = new Models.DB.UsuarioContext())
            {

                var lst = (from d in BDEmpleado.Vinculacion
                           select new Vinculacion
                           {
                               Idvinculacion = d.Idvinculacion,
                               IdEmpleado = d.IdEmpleado,
                               FechaIngreso = d.FechaIngreso,
                               Idcargo= d.Idcargo,
                               FechaRetiro = d.FechaRetiro,
                               FechaRegistro =d.FechaRegistro

                           }).ToList();
                foreach (var item in lst)
                {
                    lstEmp.Add(item);
                }

            }
            return View();
        }
    }
}