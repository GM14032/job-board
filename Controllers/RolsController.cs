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
    [Route("api/rols")]
    [ApiController]
    public class RolsController : ControllerBase
    {
        private readonly SupertexDbContext _context;

        public RolsController(SupertexDbContext context)
        {
            _context = context;
        }

        // GET: api/Rols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rol>>> GetRols()
        {
          if (_context.Rols == null)
          {
              return NotFound();
          }
            return await _context.Rols.ToListAsync();
        }

        // GET: api/Rols/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {
          if (_context.Rols == null)
          {
              return NotFound();
          }
            var rol = await _context.Rols.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        // PUT: api/Rols/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRol(int id, Rol rol)
        {
            if (id != rol.Id)
            {
                return BadRequest();
            }

            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(id))
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

        // POST: api/Rols
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rol>> PostRol(Rol rol)
        {
          if (_context.Rols == null)
          {
              return Problem("Entity set 'SupertexDbContext.Rols'  is null.");
          }
            _context.Rols.Add(rol);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RolExists(rol.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRol", new { id = rol.Id }, rol);
        }

        // DELETE: api/Rols/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRol(int id)
        {
            if (_context.Rols == null)
            {
                return NotFound();
            }
            var rol = await _context.Rols.FindAsync(id);
            if (rol == null)
            {
                return NotFound();
            }

            _context.Rols.Remove(rol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RolExists(int id)
        {
            return (_context.Rols?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
