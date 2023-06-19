using CommonModel.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class CommentService:ICommentService
    {
        private readonly ICommentRepository commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public async Task<Comment> AddAsync(Comment comment)
        {
            return await commentRepository.AddAsync(comment);
        }

        async Task<List<Comment>> ICommentService.GetCommentsByEventId(Guid eventId)
        {
            return await commentRepository.GetCommentsByEventId(eventId);
        }

       

    }
}
