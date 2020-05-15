using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.ComponentModel.DataAnnotations;

namespace Coursal_IT_2020_spring_DbaServices.Models
{
    public class Blog
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Post> Posts { get; set; } 
        public User Author { get; set; }

    }
}
