using CommonModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface ICommentService
    {
        Task<Comment> AddAsync(Comment comment);
        Task<List<Comment>> GetCommentsByEventId(Guid eventId);
    }
}
