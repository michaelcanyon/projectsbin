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
    public class AccountActions : IAccountActions
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IUserRepository _userRepository;
        public AccountActions(IBlogRepository blogRepository,IUserRepository userRepository)
        {
            _blogRepository = blogRepository;
            _userRepository = userRepository;
        }

        public async Task<bool> CreateAccount(string username, string email, string password, string passwordConfirmation, string blogTitle)
        {    
            if (password == passwordConfirmation)
            {
                User author = new User { Email = email, Nickname = username, Password = password };
                Blog blog = new Blog { Author = author, Posts = new List<Post>(), Title = blogTitle };
                bool vacantUsername= await _userRepository.ifUsernameBusy(author.Nickname);
                if (!vacantUsername)
                {
                    await _blogRepository.Create(blog);
                    await _userRepository.Create(author);
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteAccount(string authorNickname, string password, string passwordConfirmation)
        {

            if (password == passwordConfirmation)
            {
                User removableAuthor = await _userRepository.GetByNickname(authorNickname, password);
                if(removableAuthor != null)
                {
                    Blog removableBlog =await _blogRepository.GetByAuthor(removableAuthor);
                    await _blogRepository.Delete(removableBlog);
                    await _userRepository.Delete(removableAuthor);
                    return true;
                }
                return false;
            }
            return false;
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
           return await _blogRepository.GetList();
        }

        public async Task<Blog> GetSingleBlog(string authorNickname)
        {
            User Author = await _userRepository.GetByNickname(authorNickname);
            return await _blogRepository.GetByAuthor(Author);
        }

        public async Task Update(Blog entity)
        {
           await _blogRepository.Update(entity);
        }
    }
}
