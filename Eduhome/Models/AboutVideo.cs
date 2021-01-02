using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class AboutVideo
    {
        public int id { get; set; }
        [Required, StringLength(150)]
        public string Video { get; set; }
    }
}
