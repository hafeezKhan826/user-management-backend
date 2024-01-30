using AspNetCoreDemo.Data;
using AspNetCoreDemo.Models;

public class UserProfileService
{
    private readonly AppDbContext _dbContext;

    public UserProfileService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<UserProfile> GetAllProfiles()
    {
        return _dbContext.UserProfiles.ToList();
    }

    public UserProfile? GetProfileById(int id)
    {
        return _dbContext.UserProfiles.FirstOrDefault(p => p.Id == id);
    }

    public void AddProfile(UserProfile profile)
    {
        _dbContext.UserProfiles.Add(profile);
        _dbContext.SaveChanges();
    }

    public void UpdateProfile(UserProfile profile)
    {
        _dbContext.UserProfiles.Update(profile);
        _dbContext.SaveChanges();
    }

    public void DeleteProfile(int id)
    {
        var profile = _dbContext.UserProfiles.FirstOrDefault(p => p.Id == id);
        if (profile != null)
        {
            _dbContext.UserProfiles.Remove(profile);
            _dbContext.SaveChanges();
        }
    }
}
