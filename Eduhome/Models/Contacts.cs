using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Contacts
    {
        public int id { get; set; }
        [Required,StringLength(100)]
        public string Address { get; set; }
        [Required,StringLength(150)]
        public string City { get; set; }
        [StringLength(150)]
        public string AddressLogo { get; set; }
        public bool isDeleted { get; set; }
    }
}
