using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring_DbaServices.Infrastructures
{
    /// <summary>
    /// Действия с объектом поста
    /// </summary>
    public class PostRepository
    {
        IGridFSBucket gridFS;
        IMongoCollection<Post> Posts;

        public PostRepository()
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
            Posts = database.GetCollection<Post>("Posts");
           // Post newPost = new Post { Author = "Michael", Id = "0", Text = "abcdefg", Title = "NewTitle" };
            //Posts.InsertOne(newPost);
        }
        public async Task Create(Post post)
        {
            await Posts.InsertOneAsync(post);
        }

        public async Task Delete(string id)
        {
            await Posts.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }

        public async Task<IEnumerable<Post>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<Post>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await Posts.Find(filter).ToListAsync();
        }

        public async Task<Post> GetSingle(string postId)
        {
            return await Posts.Find(new BsonDocument("_id", new ObjectId(postId))).FirstOrDefaultAsync();
        }
        public async Task Update(Post post)
        {
            await Posts.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(post.Id)), post);
        }

    }

}
