using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring_DbaServices.Models;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.GridFS;
using MongoDB.Driver;

namespace Coursal_IT_2020_spring_DbaServices.Infrastructures
{
    /// <summary>
    /// Действия с объектом тега
    /// </summary>
    public class TagRepository
    {
        IGridFSBucket gridFS;
        IMongoCollection<PostTag> PostTags;

        public TagRepository()
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
            PostTags = database.GetCollection<PostTag>("PostTags");
        }
        public async Task Create(PostTag tag)
        {
            await PostTags.InsertOneAsync(tag);
        }

        public async Task Delete(string id)
        {
            await PostTags.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }

        public async Task<IEnumerable<PostTag>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<PostTag>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await PostTags.Find(filter).ToListAsync();
        }

        public async Task<PostTag> GetSingle(string TagId)
        {
            return await PostTags.Find(new BsonDocument("_id", new ObjectId(TagId))).FirstOrDefaultAsync();
        }
        public async Task Update(PostTag tag)
        {
            await PostTags.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(tag.Id)), tag);
        }

    }
}
