using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using System.Threading.Tasks;
using System.IO;
using Coursal_IT_2020_spring.Infrastructures.Repositories;
using Microsoft.Extensions.Configuration;

namespace Coursal_IT_2020_spring.Infrastructures
{
    /// <summary>
    /// Действия с объектами блога
    /// </summary>
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        //private IMongoCollection<Blog> _context.Blogs.;
        private readonly IBlogContext _context;
        public BlogRepository(IBlogContext context)
        {
            _context = context;
            //Доступ к хранилищу
            //_context.Blogs. = db.GetCollection<Blog>(settings.DBCollection);
        }

        public async Task Create(Blog blog)
        {
            //Blog blog1 = new Blog
            //{
            //    Author = methParams.Author,
            //    Posts = new List<Post>(),
            //    Title = methParams.BlogName
            //};
            await _context.Blogs.InsertOneAsync(blog);
        }
        public async Task<IEnumerable<Blog>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Blog>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await _context.Blogs.Find(filter).ToListAsync();
        }
        public async Task<Blog> GetSingle(string id)
        {
            return await _context.Blogs.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
        }
        public async Task Update(Blog blog)
        {
            await _context.Blogs.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(blog.Id)), blog);
        }
        public async Task Delete(Blog blog)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", blog.Author.Nickname) & Builders<Blog>.Filter.Eq("Author.Password", blog.Author.Password);
            await _context.Blogs.DeleteOneAsync(filter);
        }
        public async Task<Blog> GetByAuthor(User author)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", author.Nickname);
            var buff = await _context.Blogs.Find(filter).ToListAsync();
            foreach (var i in buff)
            {
                return i;
            }
            return null;
        }

        public async Task InsertPost(User author, Post post)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", author.Nickname);
            var update = Builders<Blog>.Update.AddToSet(x => x.Posts, post);
            var result = await _context.Blogs.UpdateOneAsync(filter, update);
        }

        public async Task DeletePost(Post post)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", post.Author.Nickname);
            var newp = await _context.Blogs.Find(filter).ToListAsync();
            foreach (var item in newp)
            {
                foreach (var it in item.Posts)
                {
                    if (it.Title == post.Title)
                    {
                        post = it;
                    }
                }
            }
            var update = Builders<Blog>.Update.Pull(x => x.Posts, post);
            var result = await _context.Blogs.UpdateOneAsync(filter, update);
        }

        public async Task ReplacePostByTitle(Post post)
        {
            Post _removablePost = post;
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", post.Author.Nickname);
            var newp = await _context.Blogs.Find(filter).ToListAsync();
            foreach (var item in newp)
            {
                foreach (var it in item.Posts)
                {
                    if (it.Title == post.Title)
                    {
                        _removablePost = it;
                    }
                }
            }
            var update = Builders<Blog>.Update.Pull(x => x.Posts, _removablePost);
            var result = await _context.Blogs.UpdateOneAsync(filter, update);
            update = Builders<Blog>.Update.AddToSet(x => x.Posts, post);
            result = await _context.Blogs.UpdateOneAsync(filter, update);
        }
    }
}
