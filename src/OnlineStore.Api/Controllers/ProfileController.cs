using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Interfaces;

namespace OnlineStore.Api.Controllers
{
    [Route("api/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile() => Ok(await _profileService.GetProfileAsync());
    }
}
