using Coursal_IT_2020_spring.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Coursal_IT_2020_spring.IRepositories
{
    /// <summary>
    /// Пост
    /// </summary>
    public interface IPostRepository : IBaseRepository<Post>
    {
        public Task<Post> GetPostByTitle(string Title, string authorNickname);
        public Task<IEnumerable<Post>> GetPostsByAuthor(User author);
    }
}
