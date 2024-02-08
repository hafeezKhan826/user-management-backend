using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace AspNetCoreDemo.Models
{
    [BsonIgnoreExtraElements]
    public class UserProfile
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [Required]
        [BsonElement("name")]
        public string? Name { get; set; }

        [Required]
        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("profilePicture")]
        public string? ProfilePicture { get; set; }

        [BsonElement("bio")]
        public string? Bio { get; set; }

        [BsonElement("isAvailable")]
        // [Bson]
        public bool? IsAvailable { get; set; }

        [Required]
        [BsonElement("password")]
        public string? Password { get; set; }
    }
}
