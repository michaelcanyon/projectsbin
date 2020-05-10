﻿using Coursal_IT_2020_spring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
