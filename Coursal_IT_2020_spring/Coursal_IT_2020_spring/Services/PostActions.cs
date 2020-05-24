using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coursal_IT_2020_spring.Models;
using Coursal_IT_2020_spring.Services.Interfaces;
using Coursal_IT_2020_spring.IRepositories;

namespace Coursal_IT_2020_spring.Services
{
    public class PostActions : IPostActions
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IPostRepository _postRepository;
        private readonly IUserRepository _userRepository;
        public PostActions(IBlogRepository blogRepository, IPostRepository postRepository, IUserRepository userRepository)
        {
            _blogRepository = blogRepository;
            _postRepository = postRepository;
            _userRepository = userRepository;
        }
        public async Task DeletePost(string postTitle, string authorNickname)
        {
            Post RemovablePost = await _postRepository.GetPostByTitle(postTitle, authorNickname);
            if (RemovablePost != null)
            {
                await _blogRepository.DeletePostFromBlog(RemovablePost);
                await _postRepository.Delete(RemovablePost);
            }
        }

        public async Task<IEnumerable<Post>> GetPostsByAuthor(string authorNickname)
        {
            User author = await _userRepository.GetByNickname(authorNickname);
            return await _postRepository.GetPostsByAuthor(author);
        }

        public async Task InsertPost(string authorNickname, string postTitle, string postText, DateTime dateTime, string[] tags)
        {
            User author = await _userRepository.GetByNickname(authorNickname);
            Post post = new Post { Author = author, Title = postTitle, Text = postText, Publicationtime = dateTime, Tags = new List<string>() };
            foreach (var tag in tags)
            {
                post.Tags.Add(tag);
            }
            await _postRepository.Create(post);
            post = await _postRepository.GetPostByTitle(postTitle, authorNickname);
            if (post != null)
                await _blogRepository.InsertPostIntoBlog(author, post);

        }

        public async Task ReplacePostByTitle(string postTitle, string authorNickname, Post post)
        {
            var getPost = await _postRepository.GetPostByTitle(postTitle, authorNickname);
            getPost.Publicationtime = post.Publicationtime;
            getPost.Tags = post.Tags;
            getPost.Text = post.Text;
            getPost.Title = post.Title;
           await _blogRepository.ReplacePostByTitleInBlog(getPost);
           await _postRepository.Update(getPost);
        }
    }
}
