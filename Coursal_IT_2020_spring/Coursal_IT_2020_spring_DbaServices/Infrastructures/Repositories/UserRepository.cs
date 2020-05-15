using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring_DbaServices.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring_DbaServices.Infrastructures
{
    /// <summary>
    /// Действия с объектом пользователя
    /// </summary>
    public class UserRepository
    {
        IGridFSBucket gridFS;
        IMongoCollection<User> Users;

        public UserRepository()
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
            Users = database.GetCollection<User>("Users");
        }
        public async Task Create(User user)
        {
         await  Users.InsertOneAsync(user);
        }

        public async Task Delete(string id)
        {
          await  Users.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
        }

        public async Task<IEnumerable<User>> GetList()
        {
            // строитель фильтров
            var builder = new FilterDefinitionBuilder<User>();
            var filter = builder.Empty; // фильтр для выборки всех документов
            return await Users.Find(filter).ToListAsync();
        }

        public async Task<User> GetSingle(string UserId)
        {
            return await Users.Find(new BsonDocument("_id", new ObjectId(UserId))).FirstOrDefaultAsync();
        }
        public async Task Update(User user)
        {
            await Users.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(user.Id)), user);
        }

    }
}
