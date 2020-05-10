using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;

namespace Coursal_IT_2020_spring.Infrastructures
{
    /// <summary>
    /// Действия с объектом поста
    /// </summary>
    public class PostRepository : IPostRepository
    {
        private PostContext db;

        public PostRepository()
        {
           db = new PostContext();
        }
        public void Create(Post post)
        {
            db.Posts.Add(post);
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
        }

        public List<Post> GetList()
        {
            return db.Posts.ToList();
        }

        public Post GetSingle(int postId)
        {
            return db.Posts.Find(postId);
        }
        public void Update(Post obj)
        {
            //?
        }

    }

}
