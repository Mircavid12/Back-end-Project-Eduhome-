using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class BlogVM
    {
        public List<Blogs> Blogs { get; set; }
        public List<BlogDetails> BlogDetails { get; set; }
        public List<Categories> Categories { get; set; }
        public List<LatestPosts> LatestPosts { get; set; }
        public List<Tags> Tags { get; set; }
    }
}
