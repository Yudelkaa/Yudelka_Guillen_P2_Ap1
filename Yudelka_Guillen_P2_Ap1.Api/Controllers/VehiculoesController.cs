using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Yudelka_Guillen_P2_Ap1.Api.DAL;

namespace Yudelka_Guillen_P2_Ap1.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoesController : ControllerBase
    {
        private readonly Contexto _context;

        public VehiculoesController(Contexto context)
        {
            _context = context;
        }
        [HttpGet]

        // GET: api/Vehiculoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculo()
        {
            return await _context.Vehiculo.Include(op => op.VehiculoId).ToListAsync();
        }

        // GET: api/Vehiculoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {

            var vehiculo = await _context.Vehiculo.Include(t => t.VehiculoDetalle).Where(t => t.VehiculoId == id).FirstOrDefaultAsync();

            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        // PUT: api/Vehiculoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.VehiculoId)
            {
                return BadRequest();
            }

            _context.Entry(vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(id))
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

        // POST: api/Vehiculoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo vehiculo)
        {
            if (!VehiculoExists(vehiculo.VehiculoId))
                _context.Vehiculo.Add(vehiculo);
            else
                _context.Vehiculo.Update(vehiculo);
            await _context.SaveChangesAsync();
            return Ok(vehiculo);
        }

        // DELETE: api/Vehiculoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculo.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculo.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculo.Any(e => e.VehiculoId == id);
        }

    }

}

