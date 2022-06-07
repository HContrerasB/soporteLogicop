using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapiSL.Data;
using webapiSL.Models;

namespace webapiSL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinculacionsController : ControllerBase
    {
        private readonly webapiSLContext _context;

        public VinculacionsController(webapiSLContext context)
        {
            _context = context;
        }

        // GET: api/Vinculacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vinculacion>>> GetVinculacion()
        {
            return await _context.Vinculacion.ToListAsync();
        }

        // GET: api/Vinculacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vinculacion>> GetVinculacion(decimal id)
        {
            var vinculacion = await _context.Vinculacion.FindAsync(id);

            if (vinculacion == null)
            {
                return NotFound();
            }

            return vinculacion;
        }

        // PUT: api/Vinculacions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVinculacion(decimal id, Vinculacion vinculacion)
        {
            if (id != vinculacion.Idvinculacion)
            {
                return BadRequest();
            }

            _context.Entry(vinculacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VinculacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vinculacions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vinculacion>> PostVinculacion(Vinculacion vinculacion)
        {
            _context.Vinculacion.Add(vinculacion);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VinculacionExists(vinculacion.Idvinculacion))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVinculacion", new { id = vinculacion.Idvinculacion }, vinculacion);
        }

        // DELETE: api/Vinculacions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vinculacion>> DeleteVinculacion(decimal id)
        {
            var vinculacion = await _context.Vinculacion.FindAsync(id);
            if (vinculacion == null)
            {
                return NotFound();
            }

            _context.Vinculacion.Remove(vinculacion);
            await _context.SaveChangesAsync();

            return vinculacion;
        }

        private bool VinculacionExists(decimal id)
        {
            return _context.Vinculacion.Any(e => e.Idvinculacion == id);
        }
    }
}
