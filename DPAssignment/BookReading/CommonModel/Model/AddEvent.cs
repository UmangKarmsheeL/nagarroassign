using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommonModel.Model
{
    public class AddEvent
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public TimeSpan startTime { get; set; }
        public string location { get; set; }
        public bool Visible { get; set; }
        public string description { get; set; }
        public int durationInHours { get; set; }
        public string otherDetails { get; set; }
        public string InviteByEmail { get; set; }
        public string Organiser { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
