using System.Security.Claims;

namespace ESST6.Helpers;

public class IdentityHelper
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public IdentityHelper(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetCurrentUserId()
    {
        return _httpContextAccessor.HttpContext?.User?.FindFirst(i => i.Type == "userId")?.Value;
    }
}
