using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class EventVM
    {
        public List<Events> Events { get; set; }
        public List<EventDetails> EventDetails { get; set; }
        public List<Categories> Categories { get; set; }
        public List<LatestPosts> LatestPosts { get; set; }
        public List<Tags> Tags { get; set; }
        public List<Speakers> Speakers { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
