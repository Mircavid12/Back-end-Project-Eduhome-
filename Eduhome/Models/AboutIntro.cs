using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class AboutIntro
    {
        public int id { get; set; }
        [Required,StringLength(250)]
        public string Title { get; set; }

        [Required, StringLength(150)]
        public string Image { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
