using ESST6.DAL.DBContext;
using ESST6.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESST6.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SoilController : ControllerBase
    {
        private readonly AppDBContext _context;

        public SoilController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SoilVM>>> GetSoils()
        {
            return await _context.Soils.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SoilVM>> GetSoilVM(int id)
        {
            var soilVM = await _context.Soils.FindAsync(id);

            if (soilVM == null)
            {
                return NotFound();
            }

            return soilVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoilVM(int id, SoilVM soilVM)
        {
            if (id != soilVM.ID)
            {
                return BadRequest();
            }

            _context.Entry(soilVM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoilVMExists(id))
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

        [HttpPost]
        public async Task<ActionResult<SoilVM>> PostSoilVM(SoilVM soilVM)
        {
            _context.Soils.Add(soilVM);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoilVM", new { id = soilVM.ID }, soilVM);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoilVM(int id)
        {
            var soilVM = await _context.Soils.FindAsync(id);

            if (soilVM == null)
            {
                return NotFound();
            }

            _context.Soils.Remove(soilVM);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SoilVMExists(int id)
        {
            return _context.Soils.Any(e => e.ID == id);
        }
    }
}
