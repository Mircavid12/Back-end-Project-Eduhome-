﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class LatestPosts
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
