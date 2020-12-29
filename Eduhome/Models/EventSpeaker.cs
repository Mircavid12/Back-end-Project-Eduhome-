using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class EventSpeaker
    {
        public int id { get; set; }
        public int EventId { get; set; }
        public virtual Events Events { get; set; }
        public int SpeakerId { get; set; }
        public virtual Speakers Speakers { get; set; }
    }
}
