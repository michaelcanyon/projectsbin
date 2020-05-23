using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Services.Interfaces
{
    interface IPostActions
    {
        public Task<Blog> GetPostsByAuthor(User author);
        public Task InsertPost(User author, Post post);
        public Task DeletePost(Post post);
        public Task ReplacePostByTitle(Post post);
    }
}
