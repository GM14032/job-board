﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    class ApplicacionTrabajoDto
    {

    }

    [Route("api/aplicacionTrabajo")]
    [ApiController]
    public class AplicacionTrabajoController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public AplicacionTrabajoController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/AplicacionTrabajo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AplicacionTrabajo>>> GetAplicacionTrabajos()
        {
            return await _context.AplicacionTrabajos.ToListAsync();
        }

        // GET: api/AplicacionTrabajo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AplicacionTrabajo>> GetAplicacionTrabajo(int id)
        {
            var aplicacionTrabajo = await _context.AplicacionTrabajos.FindAsync(id);

            if (aplicacionTrabajo == null)
            {
                return NotFound();
            }

            return aplicacionTrabajo;
        }

        // PUT: api/AplicacionTrabajo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAplicacionTrabajo(int id, AplicacionTrabajo aplicacionTrabajo)
        {
            if (id != aplicacionTrabajo.Id)
            {
                return BadRequest();
            }

            _context.Entry(aplicacionTrabajo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AplicacionTrabajoExists(id))
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

        // POST: api/AplicacionTrabajo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AplicacionTrabajo>> PostAplicacionTrabajo(AplicacionTrabajo aplicacionTrabajo)
        {
            _context.AplicacionTrabajos.Add(aplicacionTrabajo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAplicacionTrabajo", new { id = aplicacionTrabajo.Id }, aplicacionTrabajo);
        }

        // DELETE: api/AplicacionTrabajo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAplicacionTrabajo(int id)
        {
            var aplicacionTrabajo = await _context.AplicacionTrabajos.FindAsync(id);
            if (aplicacionTrabajo == null)
            {
                return NotFound();
            }

            _context.AplicacionTrabajos.Remove(aplicacionTrabajo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //GET: api/OfertaLaboral/oferta/6/aspirantes
        //select * from AplicacionTrabajo as atr inner join Aspirante a on atr.IdAspirante=a.Id and atr.idOferta=1;
        [HttpGet("oferta/{id}/aspirantes")]
        public async Task<ActionResult<IEnumerable<AplicacionTrabajo>>> GetAspirantes(int id)
        {
            var aplicaciones = await _context.AplicacionTrabajos
             .Where(at => at.IdOferta == id)
             .Join(_context.Aspirantes,
                 at => at.IdAspirante,
                 a => a.Id,
                 (at, a) => new
                 {
                     AplicacionTrabajo = at,
                     Aspirante = a
                 })
             .ToListAsync();

            if (aplicaciones == null || aplicaciones.Count == 0)
            {
                return NotFound();
            }

            return Ok(aplicaciones);
        }
        private bool AplicacionTrabajoExists(int id)
        {
            return _context.AplicacionTrabajos.Any(e => e.Id == id);
        }
    }
}
