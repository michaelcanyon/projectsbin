using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;

namespace Coursal_IT_2020_spring.Infrastructures
{
    /// <summary>
    /// Действия с объектами блога
    /// </summary>
    public class BlogRepository : IBlogRepository
    {
        private BlogContext db;

        public BlogRepository()
        {
            db = new BlogContext();
        }

        public void Create(Blog blog)
        {
            db.Blogs.Add(blog);
        }

        public void Delete(Blog blog)
        {
            db.Blogs.Remove(blog);
        }

        public List<Blog> GetList()
        {
            return db.Blogs.ToList();
        }

        public Blog GetSingle(int blogId)
        {
            return db.Blogs.Find(blogId);
        }
        public void Update(Blog blog)
        {
            //??
        }
    }
}
