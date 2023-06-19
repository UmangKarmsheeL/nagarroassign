using CommonModel.Model;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly eventDbContext eventDbContext;

        public CommentRepository(eventDbContext eventDbContext)
        {
            this.eventDbContext = eventDbContext;
        }
        public async Task<Comment> AddAsync(Comment comment)
        {
            await eventDbContext.Comments.AddAsync(comment);
            await eventDbContext.SaveChangesAsync();
            return comment;
        }

        public async Task<List<Comment>> GetCommentsByEventId(Guid eventId)
        {
            return await eventDbContext.Comments
                .Where(c => c.EventId == eventId)
                .ToListAsync();
        }

        


    }
}
