using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/ofertaLaboral")]
    [ApiController]
    public class OfertaLaboralController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public OfertaLaboralController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/OfertaLaboral
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfertaLaboral>>> GetOfertaLaborals()
        {
            return await _context.OfertaLaborals.ToListAsync();
        }

        // GET: api/OfertaLaboral/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfertaLaboral>> GetOfertaLaboral(int id)
        {
            var ofertaLaboral = await _context.OfertaLaborals.FindAsync(id);

            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            return ofertaLaboral;
        }

        // PUT: api/OfertaLaboral/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOfertaLaboral(int id, OfertaLaboral ofertaLaboral)
        {
            if (id != ofertaLaboral.Id)
            {
                return BadRequest();
            }

            _context.Entry(ofertaLaboral).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaLaboralExists(id))
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

        // POST: api/OfertaLaboral
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfertaLaboral>> PostOfertaLaboral(OfertaLaboral ofertaLaboral)
        {
            _context.OfertaLaborals.Add(ofertaLaboral);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOfertaLaboral", new { id = ofertaLaboral.Id }, ofertaLaboral);
        }

        // DELETE: api/OfertaLaboral/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfertaLaboral(int id)
        {
            var ofertaLaboral = await _context.OfertaLaborals.FindAsync(id);
            if (ofertaLaboral == null)
            {
                return NotFound();
            }

            _context.OfertaLaborals.Remove(ofertaLaboral);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfertaLaboralExists(int id)
        {
            return _context.OfertaLaborals.Any(e => e.Id == id);
        }
    }
}
