using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace MobileBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [MaxLength(700)]
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
    }

    public class PostDBContext : DbContext 
    {
        public DbSet<Post> Posts { get; set; }
    }
}