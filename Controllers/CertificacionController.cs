﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using job_board.Models;

namespace job_board.Controllers
{
    [Route("api/certificacion")]
    [ApiController]
    public class CertificacionController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public CertificacionController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Certificacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Certificacion>>> GetCertificacions()
        {
            return await _context.Certificacions.ToListAsync();
        }

        // GET: api/Certificacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Certificacion>> GetCertificacion(int id)
        {
            var certificacion = await _context.Certificacions.FindAsync(id);

            if (certificacion == null)
            {
                return NotFound();
            }

            return certificacion;
        }

        // PUT: api/Certificacion/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCertificacion(int id, Certificacion certificacion)
        {
            if (id != certificacion.Id)
            {
                return BadRequest();
            }

            _context.Entry(certificacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CertificacionExists(id))
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

        // POST: api/Certificacion
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Certificacion>> PostCertificacion(Certificacion certificacion)
        {
            _context.Certificacions.Add(certificacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCertificacion", new { id = certificacion.Id }, certificacion);
        }

        // DELETE: api/Certificacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCertificacion(int id)
        {
            var certificacion = await _context.Certificacions.FindAsync(id);
            if (certificacion == null)
            {
                return NotFound();
            }

            _context.Certificacions.Remove(certificacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CertificacionExists(int id)
        {
            return _context.Certificacions.Any(e => e.Id == id);
        }
    }
}
