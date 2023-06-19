using CommonModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models.ViewModels
{
    public class EditEventViewModel
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
        public TimeSpan startTime { get; set; }
        public bool Visible { get; set; }
        public int durationInHours { get; set; }
        public string description { get; set; }
        public string otherDetails { get; set; }
        public string InviteByEmail { get; set; }
        public string Organiser { get; set; }
        public string CommentDescription { get; set; }
        public List<CommentViewModel> Comments { get; set; }

        
    }
}
