using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.IRepositories;
using Coursal_IT_2020_spring.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Coursal_IT_2020_spring.Infrastructures.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected IMongoDatabase db;
        protected IGridFSBucket gridFS;
        public IConfiguration Configuration { get; }
        public BaseRepository(IJournalDBSettings settings)
        {
            var client = new MongoClient(settings.connectionStr);
            db = client.GetDatabase(settings.DatabaseName);
            gridFS = new GridFSBucket(db);
            
        }
    }
}
