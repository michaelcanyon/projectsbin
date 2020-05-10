using System.Collections.Generic;
using System.Linq;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;

namespace Coursal_IT_2020_spring.Infrastructures
{
    /// <summary>
    /// Действия с объектом пользователя
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private UserContext db;

        public UserRepository()
        {
            db = new UserContext();
        }
        public void Create(User user)
        {
            db.Users.Add(user);
        }

        public void Delete(User user)
        {
            db.Users.Remove(user);
        }

        public List<User> GetList()
        {
            return db.Users.ToList();
        }

        public User GetSingle(int UserId)
        {
            return db.Users.Find(UserId);
        }
        public void Update(User user)
        {
            //?
        }

    }
}
