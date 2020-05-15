using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coursal_IT_2020_spring.Models
{
    public class PostTag
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
