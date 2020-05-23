using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coursal_IT_2020_spring.Models
{
    public class PostTag : Entity
    {
        public string Title { get; set; }
    }
}
