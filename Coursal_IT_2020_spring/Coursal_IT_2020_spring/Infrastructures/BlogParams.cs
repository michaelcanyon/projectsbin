using Coursal_IT_2020_spring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring.Infrastructures
{
    public class BlogParams
    {
        public string BlogName { get; set; }
        public User Author { get; set; }
        public Post InsertablePost { get; set;}
        public Post RemovablePost { get; set; }

        public Blog ReplacementBlog { get; set; }

    }
}
