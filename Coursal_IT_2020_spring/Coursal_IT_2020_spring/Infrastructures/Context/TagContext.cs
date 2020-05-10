using Coursal_IT_2020_spring.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring.Infrastructures
{
    public class TagContext
    {
        /// <summary>
        /// Связь интерфейса с бд
        /// </summary>
        public DbSet<Tag> Tags { get; set; }
    }
}
