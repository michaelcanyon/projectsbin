﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Coursal_IT_2020_spring_DbaServices.Models
{
    public class Post
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        //public User Author { get; set; }
        public string Author { get; set; }
       // public DateTime Publicationtime { get; set; }
       // public List<PostTag> Tags { get; set; }
        public string Title { get; set; }
        //public object Image { get; set; }
        public string Text { get; set; }
    }
}
