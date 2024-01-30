using AspNetCoreDemo.Data;
using AspNetCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly UserProfileService _profileService;

        public UserProfileController(UserProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public ActionResult<List<UserProfile>> GetAllProfiles()
        {
            return _profileService.GetAllProfiles();
        }

        [HttpGet("{id}")]
        public ActionResult<UserProfile> GetProfileById(int id)
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
        public IActionResult UpdateProfile(int id, UserProfile profile)
        {
            if (id != profile.Id)
            {
                return BadRequest();
            }
            _profileService.UpdateProfile(profile);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProfile(int id)
        {
            _profileService.DeleteProfile(id);
            return NoContent();
        }
    }
}
