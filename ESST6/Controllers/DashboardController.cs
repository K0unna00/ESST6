using ESST6.DAL.DBContext;
using ESST6.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ESST6.Controllers;
[Route("[controller]/[action]")]
[ApiController]
public class DashboardController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly AppDBContext _context;

    public DashboardController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDBContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
    }


    [HttpPost("GetDashboard")]
    public async Task<IActionResult> GetDashboard([FromBody] string userId)
    {
        var data = _context.Dashboards.FirstOrDefault(x => x.UserId == userId);

        return Ok(data);
    }
}
