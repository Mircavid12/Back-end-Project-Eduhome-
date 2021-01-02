using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class EventSpeaker
    {
        public int id { get; set; }
        [ForeignKey("Events")]
        public int EventId { get; set; }
        public virtual Events Events { get; set; }
        [ForeignKey("Speakers")]
        public int SpeakerId { get; set; }
        public virtual Speakers Speakers { get; set; }
    }
}
