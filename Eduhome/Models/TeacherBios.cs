﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class TeacherBios
    {
        public int id { get; set; }
        public string Name { get; set; }
        public virtual Teachers Teachers { get; set; }
        public  int TeachersId { get; set; }
    }
}
