using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Services.Interfaces
{
    interface IBlogActions
    {
        Task CreateBlog(Blog entity);
        Task Update(Blog entity);
        Task Delete(Blog entity);
        Task<Blog> GetSingle(string id);
        Task<IEnumerable<Blog>> GetList();
    }
}
