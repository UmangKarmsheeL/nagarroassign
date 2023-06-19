using CommonModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public interface IEventService
    {
        Task<IEnumerable<AddEvent>> GetAllAsync();
        Task<AddEvent?> GetAsync(Guid id);
        Task<AddEvent> AddAsync(AddEvent addEvent);
        Task<AddEvent?> UpdateAsync(AddEvent addEvent);
        Task<AddEvent?> DeleteAsync(Guid id);
        
    }
}
