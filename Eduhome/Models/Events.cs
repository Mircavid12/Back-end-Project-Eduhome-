using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Events
    {
        public int id { get; set; }
        [Required, StringLength(100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        public string Venue { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Day { get; set; }
        public string Month { get; set; }
        public bool IsDeleted { get; set; }
        public EventDetails EventDetails { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
        public ICollection<Tags> Tags { get; set; }
        public ICollection<LatestPosts> LatestPosts { get; set; }
    }
}
