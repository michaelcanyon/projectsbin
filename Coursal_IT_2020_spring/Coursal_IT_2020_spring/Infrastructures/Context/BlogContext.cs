using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;
using Microsoft.EntityFrameworkCore;

namespace Coursal_IT_2020_spring.Infrastructures
{
    public class BlogContext
    {
        /// <summary>
        /// Связь интерфейса с бд
        /// </summary>
        public DbSet<Blog> Blogs { get; set; }
    }
}
