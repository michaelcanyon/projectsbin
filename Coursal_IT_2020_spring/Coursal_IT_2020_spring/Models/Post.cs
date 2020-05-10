using System;
using System.Collections.Generic;

namespace Coursal_IT_2020_spring.Models
{
    public class Post
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public DateTime Publicationtime { get; set; }
        public List<Tag> Tags { get; set; }
        public string Title { get; set; }
        //public object Image { get; set; }
        public string Text { get; set; }
    }
}
