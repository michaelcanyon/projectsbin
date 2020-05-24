using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Services.Interfaces
{
   public interface IPostActions
    {
        public Task<IEnumerable<Post>> GetPostsByAuthor(string authorNickname);
        public Task InsertPost(string authorNickname, string postTitle, string postText, DateTime dateTime, string[] tags);
        public Task DeletePost(string postTitle, string authorNIckname);
        public Task ReplacePostByTitle(string postTitle, string authorNickname, Post post);
    }
}
