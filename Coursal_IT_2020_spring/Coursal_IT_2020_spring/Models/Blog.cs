using System.Collections.Generic;

namespace Coursal_IT_2020_spring.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Post> Posts { get; set; } 
        public User Author { get; set; }

    }
}
