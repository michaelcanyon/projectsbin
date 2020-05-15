using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coursal_IT_2020_spring_DbaServices.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nickname { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
