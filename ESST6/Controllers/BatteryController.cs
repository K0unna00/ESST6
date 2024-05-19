using ESST6.DAL.DBContext;
using ESST6.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESST6.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class BatteryController : ControllerBase
    {
        private readonly AppDBContext _context;

        public BatteryController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BatteryVM>>> GetBatteries()
        {
            return await _context.Batteries.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BatteryVM>> GetBatteryVM(int id)
        {
            var batteryVM = await _context.Batteries.FindAsync(id);

            if (batteryVM == null)
            {
                return NotFound();
            }

            return batteryVM;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatteryVM(int id, BatteryVM batteryVM)
        {
            if (id != batteryVM.Id)
            {
                return BadRequest();
            }

            _context.Entry(batteryVM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BatteryVMExists(id))
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
        public async Task<ActionResult<BatteryVM>> PostBatteryVM(BatteryVM batteryVM)
        {
            _context.Batteries.Add(batteryVM);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBatteryVM", new { id = batteryVM.Id }, batteryVM);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBatteryVM(int id)
        {
            var batteryVM = await _context.Batteries.FindAsync(id);
            if (batteryVM == null)
            {
                return NotFound();
            }

            _context.Batteries.Remove(batteryVM);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BatteryVMExists(int id)
        {
            return _context.Batteries.Any(e => e.Id == id);
        }

        [HttpGet]
        [ActionName("DashqinTest")]
        public async Task<IActionResult> DashqinTest()
        {
            return Ok("Işlədi brat");
        }
    }
}
