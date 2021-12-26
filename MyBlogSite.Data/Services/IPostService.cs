using MyBlogSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Services
{
    interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetById(Guid id);
        Post AddPost(Post newpost);
        Post UpdatePost(Post post);
        void DeletePost(Guid id);
    }
}
