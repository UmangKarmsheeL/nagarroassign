using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReadingEvent1.Data
{
    public class Events
    {
        public int Id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public DateTime startTime { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public int? duration { get; set; }
        public string organiser { get; set; }
        public string eventType { get; set; }
        public string invitees { get; set; }

    }
}
