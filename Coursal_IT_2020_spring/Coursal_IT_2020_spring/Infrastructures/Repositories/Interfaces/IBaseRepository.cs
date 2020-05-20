using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Coursal_IT_2020_spring.IRepositories
{
    /// <summary>
    /// Описывает основные действия с объектами сущностей
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T>
    {
        Task Create();
        Task Update();
        Task Delete();
        Task<T> GetSingle();
        Task<IEnumerable<T>> GetList();
    }
}
