using AspNetCoreDemo.Data;
using AspNetCoreDemo.Models;
using AspNetCoreDemo.Services;
using MongoDB.Driver;

public class UserProfileService : IUserProfileService
{
    // private readonly AppDbContext _dbContext;
    private readonly IMongoCollection<UserProfile> _profiles;
    public UserProfileService(IUserDatabaseSettings dbSettingsSettings, IMongoClient client)
    {

        var database = client.GetDatabase(dbSettingsSettings.Database);
        _profiles = database.GetCollection<UserProfile>(dbSettingsSettings.CollectionName);
    }

    public List<UserProfile> GetAllProfiles()
    {
        return _profiles.Find(user => true && user.IsAvailable == true).ToList();
    }

    public List<UserProfile> GetAllDeactivatedProfiles()
    {
        return _profiles.Find(user => true && user.IsAvailable == false).ToList();
    }

    public UserProfile? GetProfileById(string id)
    {
        return _profiles.Find(p => p.Id == id && p.IsAvailable == true).FirstOrDefault();
    }

    public void AddProfile(UserProfile profile)
    {
        profile.IsAvailable = true;
        _profiles.InsertOne(profile);
    }

    public void UpdateProfile(string id, UserProfile profile)
    {
        _profiles.ReplaceOne(profile => profile.Id == id, profile);
    }

    public void DeactivateProfile(string id)
    {
        var profile = _profiles.Find(p => p.Id == id && p.IsAvailable == true).FirstOrDefault();
        if (profile != null)
        {
            _profiles.UpdateOne(profile => profile.Id == id, Builders<UserProfile>.Update.Set(profile => profile.IsAvailable, false));
        }
    }

    public void ReactivateProfile(string id)
    {
        var profile = _profiles.Find(p => p.Id == id && p.IsAvailable == false).FirstOrDefault();
        if (profile != null)
        {
            _profiles.UpdateOne(profile => profile.Id == id, Builders<UserProfile>.Update.Set(profile => profile.IsAvailable, true));
        }
    }

    public void DeleteProfile(string id)
    {
        _profiles.DeleteOne(profile => profile.Id == id);
    }
}
