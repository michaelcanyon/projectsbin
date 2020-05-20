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
    public class BlogRepository: BaseRepository<Blog>, IBlogRepository
    {
        public BlogParams methParams;
        IMongoCollection<Blog> Blogs;
        public BlogRepository(IJournalDBSettings settings) :base(settings)
        {
            //Доступ к хранилищу
            Blogs = db.GetCollection<Blog>(settings.DBCollection);
            methParams = new BlogParams();
        }

        public async Task Create()
        {
            Blog blog1 = new Blog
            {
                Author = methParams.Author,
                Posts = new List<Post>(),
                Title = methParams.BlogName
            };
            await Blogs.InsertOneAsync(blog1);
        }

        public async Task Delete()
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", methParams.Author.Nickname) & Builders<Blog>.Filter.Eq("Author.Password", methParams.Author.Password);
            await Blogs.DeleteOneAsync(filter);
        }

        public async Task<IEnumerable<Blog>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Blog>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await Blogs.Find(filter).ToListAsync();
        }
        public async Task<Blog> GetSingle()
        {
            return await Blogs.Find(new BsonDocument("_id", new ObjectId(methParams.BlogName))).FirstOrDefaultAsync();
        }

        //не знаю, нужны ли 2 эти метода
        public async Task Update()
        {
            await Blogs.ReplaceOneAsync(new BsonDocument("_id",new ObjectId(methParams.ReplacementBlog.Id)), methParams.ReplacementBlog);
        }
        public async Task GetByAuthor(IMongoCollection<Blog> blogs, User author)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", author.Nickname);
            var buff = await blogs.Find(filter).ToListAsync();
        }
    }
}
