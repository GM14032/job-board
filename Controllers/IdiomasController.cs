﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/idiomas")]
    [ApiController]
    public class IdiomasController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public IdiomasController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Idiomas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Idioma>>> GetIdiomas()
        {
          if (_context.Idiomas == null)
          {
              return NotFound();
          }
            return await _context.Idiomas.ToListAsync();
        }

        // GET: api/Idiomas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Idioma>> GetIdioma(int id)
        {
          if (_context.Idiomas == null)
          {
              return NotFound();
          }
            var idioma = await _context.Idiomas.FindAsync(id);

            if (idioma == null)
            {
                return NotFound();
            }

            return idioma;
        }

        // PUT: api/Idiomas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIdioma(int id, Idioma idioma)
        {
            if (id != idioma.Id)
            {
                return BadRequest();
            }

            _context.Entry(idioma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IdiomaExists(id))
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

        // POST: api/Idiomas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Idioma>> PostIdioma(Idioma idioma)
        {
          if (_context.Idiomas == null)
          {
              return Problem("Entity set 'SupertexDbContext.Idiomas'  is null.");
          }
            _context.Idiomas.Add(idioma);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (IdiomaExists(idioma.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetIdioma", new { id = idioma.Id }, idioma);
        }

        // DELETE: api/Idiomas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIdioma(int id)
        {
            if (_context.Idiomas == null)
            {
                return NotFound();
            }
            var idioma = await _context.Idiomas.FindAsync(id);
            if (idioma == null)
            {
                return NotFound();
            }

            _context.Idiomas.Remove(idioma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IdiomaExists(int id)
        {
            return (_context.Idiomas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
