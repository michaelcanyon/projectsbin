using System.Collections.Generic;

namespace Coursal_IT_2020_spring.IRepositories
{
    /// <summary>
    /// Описывает основные действия с объектами сущностей
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T>
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
        T GetSingle(int objId);
        List<T> GetList();
    }
}
