using AspNetCoreDemo.Models;
using AspNetCoreDemo.Data;
public static class MockData
{
    public static List<UserProfile> UserProfiles = new List<UserProfile>
    {
        new UserProfile { Id = "1", Name = "John Doe", Email = "john@example.com", ProfilePicture = "profile.jpg", Bio = "Lorem ipsum", Password = "password123" },
        new UserProfile { Id = "2", Name = "Jane Smith", Email = "jane@example.com", ProfilePicture = "profile.jpg", Bio = "Dolor sit amet", Password = "password456" }
    };
}
