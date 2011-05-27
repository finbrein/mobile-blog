using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MobileBlog.Models
{
    public class PostInitializer : DropCreateDatabaseIfModelChanges<PostDBContext>
    {
        protected override void Seed(PostDBContext context)
        {
            var posts = new List<Post> { 
 
                 new Post { Title = "My new blog",
                             Content = "This is my first blog post...",
                             PublishDate= DateTime.Now}, 
 
                 new Post { Title = "Second post",
                             Content = "This is my second blog post. Hi!",
                             PublishDate= DateTime.Now}
             };
            posts.ForEach(d => context.Posts.Add(d));
        }
    }
}