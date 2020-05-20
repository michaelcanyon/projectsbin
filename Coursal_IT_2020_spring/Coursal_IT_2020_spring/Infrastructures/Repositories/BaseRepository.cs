using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.IRepositories;
using Coursal_IT_2020_spring.Models;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Coursal_IT_2020_spring.Infrastructures.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected IMongoDatabase db;
        protected IGridFSBucket gridFS;
        public BaseRepository()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString;
            var connection = new MongoUrlBuilder(connectionStr);
            MongoClient client = new MongoClient(connectionStr);
            db = client.GetDatabase(connection.DatabaseName);
            gridFS = new GridFSBucket(db);
            
        }
    }
}
