using MyBlogSite.Data.DataEfPost;
using MyBlogSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Services
{
    public class PostService : IPostService
    {
        private readonly PostDb _dbContext;
        public PostService(PostDb dbContext)
        {
            _dbContext = dbContext;

        }
        public Post AddPost(Post newpost)
        {
            _dbContext.Add(newpost);
            _dbContext.SaveChanges();

            return newpost;
        }

        public void DeletePost(Guid id)
        {
            Post post = _dbContext.Posts.FirstOrDefault(p => p.Id == id);
            _dbContext.Posts.Remove(post);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _dbContext.Posts;
        }

        public Post GetById(Guid id)
        {
            return _dbContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public Post UpdatePost(Post post)
        {
            _dbContext.Posts.Update(post);
            _dbContext.SaveChanges();

            return post;

        }
    }
}
