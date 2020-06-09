﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;

namespace Coursal_IT_2020_spring.ViewModels
{
    public class PostViewModel
    {
        public string nickname { get; set; }
        public string password { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }
        //public object Image { get; set; }
        public string text { get; set; }
        public Post ToPostObject()
        {
            User author = new User { Nickname = nickname, Password=password };
            return new Post { Author = author, Publicationtime = DateTime.Now, Tags = tags, Text = text, Title = title };
        }
    }
}
