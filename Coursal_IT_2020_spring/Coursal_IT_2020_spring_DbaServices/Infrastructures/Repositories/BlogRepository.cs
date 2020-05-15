using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using System.Threading.Tasks;
using System.IO;
using Coursal_IT_2020_spring_DbaServices.Models;

namespace Coursal_IT_2020_spring_DbaServices.Infrastructures
{
    /// <summary>
    /// Действия с объектами блога
    /// </summary>
    public class BlogRepository
    {
        IGridFSBucket gridFS;
        IMongoCollection<Blog> Blogs;
        public BlogRepository()
        {
            //Подключение базы данных 
            string connectionString = "mongodb://localhost:27017/journal";
            var connection = new MongoUrlBuilder(connectionString);
            //Получение клиента(что делает клиент) для взаимодействия с бд
            MongoClient client = new MongoClient(connectionString);
            //Получение доступа к самой бд
            IMongoDatabase database = client.GetDatabase(connection.DatabaseName);
            //Доступ к файловому харнилищу
            gridFS = new GridFSBucket(database);
            //Доступ к хранилищу
            Blogs = database.GetCollection<Blog>("Blogs");
        }

        public async Task Create(Blog blog)
        {
            await Blogs.InsertOneAsync(blog);
        }

        public async Task Delete(string id)
        {
            await Blogs.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }

        public async Task<IEnumerable<Blog>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Blog>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await Blogs.Find(filter).ToListAsync();
        }

        public async Task<Blog> GetSingle(string blogId)
        {
            return await Blogs.Find(new BsonDocument("_id", new ObjectId(blogId))).FirstOrDefaultAsync();
        }
        public async Task Update(Blog blog)
        {
            await Blogs.ReplaceOneAsync(new BsonDocument("_id",new ObjectId(blog.Id)), blog);
        }
    }
}
