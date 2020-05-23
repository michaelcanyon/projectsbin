using Coursal_IT_2020_spring.Models;
using MongoDB.Driver;
using System.Collections;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring.IRepositories
{
    /// <summary>
    /// Блог
    /// </summary>
    interface IBlogRepository : IBaseRepository<Blog>
    {
        public Task<Blog> GetByAuthor(User author);
        public Task InsertPost(User author, Post post);
        public Task DeletePost(Post post);
        public Task ReplacePostByTitle(Post post);
    }
}
