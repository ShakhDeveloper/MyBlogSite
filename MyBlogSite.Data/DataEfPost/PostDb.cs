using Microsoft.EntityFrameworkCore;
using MyBlogSite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.DataEfPost
{
    public class PostDb : DbContext
    {
        public PostDb(DbContextOptions<PostDb> options)
            : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
