using Business.Service;
using CommonModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Facade
{
    public class EventServiceFacade : IEventService
    {
        private readonly IEventService eventService;

        public EventServiceFacade(IEventService eventService)
        {
            this.eventService = eventService;
        }
        public async Task<AddEvent> AddAsync(AddEvent addEvent)
        {
            return await eventService.AddAsync(addEvent);
        }

        public async Task<AddEvent> DeleteAsync(Guid id)
        {
           return await eventService.DeleteAsync(id);
        }

        public async Task<IEnumerable<AddEvent>> GetAllAsync()
        {
            return await eventService.GetAllAsync();
        }

        public async Task<AddEvent> GetAsync(Guid id)
        {
            return await eventService.GetAsync(id);
        }

        public async Task<AddEvent> UpdateAsync(AddEvent addEvent)
        {
            return await eventService.UpdateAsync(addEvent);
        }
    }
}
