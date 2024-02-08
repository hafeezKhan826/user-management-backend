using AspNetCoreDemo.Data;
using AspNetCoreDemo.Models;
using AspNetCoreDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemo.Controllers
{
    [ApiController]
    [Route("api/profile")]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _profileService;

        public UserProfileController(IUserProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public ActionResult<List<UserProfile>> GetAllProfiles()
        {
            return _profileService.GetAllProfiles();
        }

        [HttpGet("deactivatedUsers")]
        public ActionResult<List<UserProfile>> GetAllDeactivatedProfiles()
        {
            return _profileService.GetAllDeactivatedProfiles();
        }

        [HttpGet("{id}")]
        public ActionResult<UserProfile> GetProfileById(string id)
        {
            var profile = _profileService.GetProfileById(id);
            if (profile == null)
            {
                return NotFound();
            }
            return profile;
        }

        [HttpPost]
        public IActionResult AddProfile(UserProfile profile)
        {
            _profileService.AddProfile(profile);
            return CreatedAtAction(nameof(GetProfileById), new { id = profile.Id }, profile);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProfile(string id, UserProfile profile)
        {
            if (id != profile.Id)
            {
                return BadRequest();
            }
            _profileService.UpdateProfile(id, profile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProfile(string id)
        {
            _profileService.DeactivateProfile(id);
            return NoContent();
        }

        [HttpPatch("reactivate/{id}")]
        public IActionResult ReactiveProfile(string id)
        {
            _profileService.ReactivateProfile(id);
            return NoContent();
        }
    }
}
