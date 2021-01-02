using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Chooses
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }

    }
}
