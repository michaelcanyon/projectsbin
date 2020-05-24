using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Services.Interfaces
{
    public interface IAccountActions
    {
        Task<bool> CreateAccount(string username, string email, string password, string passwordConfirmation, string blogTitle);
        Task Update(Blog entity);
        Task<bool> DeleteAccount(string authorNickname, string password, string passwordConfirmation);
        Task<Blog> GetSingleBlog(string authorNickname);
        Task<IEnumerable<Blog>> GetBlogs();
    }
}
