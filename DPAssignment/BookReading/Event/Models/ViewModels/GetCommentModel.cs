using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Models.ViewModels
{
    public class GetCommentModel
    {
        public string Description { get; set; }
        public string UserName { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
