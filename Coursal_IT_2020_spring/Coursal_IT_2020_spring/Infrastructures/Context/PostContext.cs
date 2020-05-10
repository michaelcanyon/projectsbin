using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring;
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
