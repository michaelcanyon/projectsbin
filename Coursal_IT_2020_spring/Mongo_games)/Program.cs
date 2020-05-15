using System;
using MongoDB.Bson;
using MongoDB.Driver;
using Mongo_games.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mongo_games_
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase db = client.GetDatabase("NewDB1");
            var blogsCollection = db.GetCollection<Blog>("Blogs");
            InsertBlogs(blogsCollection).GetAwaiter().GetResult();
            ModifyNote(blogsCollection).GetAwaiter().GetResult();
           // DeleteNote(blogsCollection).GetAwaiter().GetResult();
            PrintBlogs(blogsCollection).GetAwaiter().GetResult();



        }
        static async Task InsertBlogs(IMongoCollection<Blog> blogs)
        {
            User author = new User { Email = "Example@gmail.com", Nickname = "Ciceron", Password = "Ddcsm32214m" };
            Blog blog1 = new Blog
            {
                Author = author,
                Posts = new List<Post>
            { new Post { Author=author, Publicationtime=new DateTime(2012,06,17),
            Tags=new List<PostTag>{ new PostTag { Title="Space" }, new PostTag { Title = "Chemestry" }, new PostTag { Title = "Physics" } },
            Text="lorem ipsum dolor sit amet consectetur adipiscing elit. donec dolor", Title="Размножение летучих мышей"
            },
              new Post { Author=author, Publicationtime=new DateTime(2016,02,05),
            Tags=new List<PostTag>{ new PostTag { Title="Nature" }, new PostTag { Title = "Body" }, new PostTag { Title = "Physics" } },
            Text="Arcu ac tortor dignissim convallis aenean et tortor at. Pretium viverra suspendisse potenti nullam ac tortor vitae purus. " +
            "Eros donec ac odio tempor orci dapibus ultrices. Elementum nibh tellus molestie nunc. Et magnis dis parturient montes nascetur. ",
             Title="Антикарантинные крэма"
            },
               new Post { Author=author, Publicationtime=new DateTime(2018,01,02),
            Tags=new List<PostTag>{ new PostTag { Title="Space" }, new PostTag { Title = "Stones" }},
            Text="Arcu ac tortor dignissim convallis aenean et tortor at. Pretium viverra suspendisse potenti nullam ac tortor vitae purus. " +
            "Eros donec ac odio tempor orci dapibus ultrices. Elementum nibh tellus molestie nunc. Et magnis dis parturient montes nascetur. ",
             Title="Метеоритные дэждь"
            }
            },
                Title = "Заметки Павла 1 кандилябра"
            };
            User author1 = new User { Email = "Example123@gmail.com", Nickname = "Chelowek_Geranj", Password = "kjvnersw3" };
            Blog blog2 = new Blog
            {
                Author = author,
                Posts = new List<Post>
            { new Post { Author=author1, Publicationtime=new DateTime(2015,10,29),
            Tags=new List<PostTag>{ new PostTag { Title="Plants" }, new PostTag { Title = "Chemestry" }, new PostTag { Title = "Nature" } },
            Text=" Nunc pulvinar sapien et ligula ullamcorper malesuada proin. Neque convallis a cras semper auctor", Title="Выращивание цветов на гормонах"
            },
              new Post { Author=author1, Publicationtime=new DateTime(2016,02,15),
            Tags=new List<PostTag>{ new PostTag { Title="Music" }, new PostTag { Title = "Physics" } },
            Text="per sit amet risus. Et malesuada fames ac turpis egestas sed. Sit amet nisl suscipit adipiscing bibendum est ultricies. Arcu ac tortor dignissim convallis aenean et tortor at. Pretium viverra suspendisse potenti nullam ac tortor vitae purus. Eros donec ac odio tempor " +
            "orci dapibus ultrices. Elementum nibh tellus molestie nunc. Et magnis dis parturient montes nascetur. " +
            "Est placerat in egestas erat imperdiet. Consequat in ",
             Title="Высокие частоты и камни"
            },
               new Post { Author=author1, Publicationtime=new DateTime(2013,04,13),
            Tags=new List<PostTag>{ new PostTag { Title="Sounds" }, new PostTag { Title = "Music" }},
            Text="Fames ac turpis egestas maecenas. Bibendum neque egestas congue quisque egestas diam. Laoreet id donec ultrices",
             Title="Музыкальное программирование"
            }
            },
                Title = "Заметки Павла 2 кандилябра"
            };
            await blogs.InsertOneAsync(blog1);
            await blogs.InsertOneAsync(blog2);
        }
        static async Task PrintBlogs(IMongoCollection<Blog> blogs)
        {
            BsonDocument filter = new BsonDocument();
            var buff = await blogs.Find(filter).ToListAsync();
            foreach (var item in buff)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", item.Id, item.Title, item.Author.Nickname, item.Author.Email);
                foreach (var p in item.Posts)
                {
                    Console.WriteLine("{0} - {1} - {2}", p.Id, p.Title, p.Text);
                    foreach (var it in p.Tags)
                    {
                        Console.WriteLine(it.Title);
                    }
                }

            }
        }
        static async Task ModifyNote(IMongoCollection<Blog> blogs)
        {

            var update = await blogs.UpdateManyAsync(new BsonDocument("Author.Nickname", "Ciceron"), new BsonDocument("$set", new BsonDocument("Author.Email", "replacedmail@ya.ru")));
            Console.WriteLine("найдено по соответствию: {0}; обновлено: {1}",
    update.MatchedCount, update.ModifiedCount);
           // var filter = Builders<Blog>.Filter.Eq("Author.Nickname", "Ciceron");
            //var update1 = Builders<Blog>.Update.AddToSet("Tags", new PostTag { Title = "Новый тег" });
            //var result = await blogs.UpdateManyAsync(filter, update1);
        }
        static async Task DeleteNote(IMongoCollection<Blog> blogs)
        {
            var filter = Builders<Blog>.Filter.Eq("Author.Nickname", "Ciceron");
            await blogs.DeleteManyAsync(filter);
        }
    }
}

