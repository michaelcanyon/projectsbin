using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring.Infrastructures
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

    }
}
