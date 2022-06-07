using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapiSL.Models;

namespace webapiSL.Data
{
    public class webapiSLContext : DbContext
    {
        public webapiSLContext (DbContextOptions<webapiSLContext> options)
            : base(options)
        {
        }

        public DbSet<webapiSL.Models.Empleado> Empleado { get; set; }

        public DbSet<webapiSL.Models.Vinculacion> Vinculacion { get; set; }
    }
}
