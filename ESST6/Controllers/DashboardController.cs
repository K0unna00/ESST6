using ESST6.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ESST6.Controllers;
[Route("[controller]/[action]")]
[ApiController]
public class DashboardController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public DashboardController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }


    [HttpGet]
    public async Task<ActionResult<BatteryVM>> GetBatteryVM(int id)
    {
        var userId = _userManager.GetUserId(User);


        return Ok();
    }
}
