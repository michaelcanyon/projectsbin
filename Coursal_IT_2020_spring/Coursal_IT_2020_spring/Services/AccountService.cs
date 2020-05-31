using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.IRepositories;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.Services.Interfaces;
using MongoDB.Driver;

namespace Coursal_IT_2020_spring.Services
{
    public class AccountService : IAccountService
    {
       // private readonly IBlogRepository _blogRepository;
        private readonly IUserRepository _userRepository;
        public AccountService(IUserRepository userRepository)
        {
          //  _blogRepository = blogRepository;
            _userRepository = userRepository;
        }

        public async Task<bool> CreateAccount(User user)
        {
            //User author = new User { Email = blog.Author.Email, Nickname = blog.Author.Nickname, Password = blog.Author.Password };
            //Blog blog = new Blog { Author = author, Posts = new List<Post>(), Title = blogTitle };
            bool vacantUsername = await _userRepository.ifUsernameBusy(user.Nickname);
            if (!vacantUsername)
            {
                await _userRepository.Create(user);
                //blog.Author = await _userRepository.GetByNickname(blog.Author.Nickname);
                //await _blogRepository.Create(blog);
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAccount(string authorNickname, string password)
        {

            User removableAuthor = await _userRepository.GetByNickname(authorNickname, password);
            if (removableAuthor != null)
            {
                //Blog removableBlog = await _blogRepository.GetByAuthor(removableAuthor);
                //await _blogRepository.Delete(removableBlog);
                await _userRepository.Delete(removableAuthor);
                return true;
            }
            return false;
        }

        public async Task<List<User>> GetAccounts()
        {
            return await _userRepository.GetList();
        }

        public async Task<User> GetAccount(string authorNickname, string password)
        {
            return await _userRepository.GetByNickname(authorNickname, password);
        }

        public async Task Update(User user)
        {
            await _userRepository.Update(user);
        }
    }
}
