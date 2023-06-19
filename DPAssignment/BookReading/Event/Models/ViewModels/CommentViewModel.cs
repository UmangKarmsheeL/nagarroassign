using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models.ViewModels
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
