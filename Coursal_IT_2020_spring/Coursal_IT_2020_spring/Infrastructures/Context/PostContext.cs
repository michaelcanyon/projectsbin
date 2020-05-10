using Microsoft.EntityFrameworkCore;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.Infrastructures
{
    public class PostContext
    {
        /// <summary>
        /// Связь интерфейса с бд
        /// </summary>
        public DbSet<Post> Posts { get; set; }
    }
}
