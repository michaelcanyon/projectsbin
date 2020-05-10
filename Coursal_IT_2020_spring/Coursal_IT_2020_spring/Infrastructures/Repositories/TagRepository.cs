using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.IRepositories;

namespace Coursal_IT_2020_spring.Infrastructures
{
    /// <summary>
    /// Действия с объектом тега
    /// </summary>
    public class TagRepository:ITagRepository
    {
        private TagContext db;

        public TagRepository()
        {
            db = new TagContext();
        }
        public void Create(Tag tag)
        {
            db.Tags.Add(tag);
        }

        public void Delete(Tag tag)
        {
            db.Tags.Remove(tag);
        }

        public List<Tag> GetList()
        {
            return db.Tags.ToList();
        }

        public Tag GetSingle(int TagId)
        {
            return db.Tags.Find(TagId);
        }
        public void Update(Tag tag)
        {
            //?
        }

    }
}
