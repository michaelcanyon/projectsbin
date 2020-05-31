using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> CreateAccount(User user);
        Task Update(User user);
        Task<bool> DeleteAccount(string authorNickname, string password);
        Task<User> GetAccount(string authorNickname,string password);
        Task<List<User>> GetAccounts();
    }
}
