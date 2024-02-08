using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreDemo.Models;

namespace AspNetCoreDemo.Services
{
    public interface IUserProfileService
    {
        List<UserProfile> GetAllProfiles();
        List<UserProfile> GetAllDeactivatedProfiles();
        UserProfile? GetProfileById(string id);
        void AddProfile(UserProfile profile);
        void UpdateProfile(string id, UserProfile profile);
        void DeactivateProfile(string id);
        void ReactivateProfile(string id);
        void DeleteProfile(string id);
    }
}