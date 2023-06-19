using CommonModel.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.CustomException;
using Microsoft.AspNetCore.Mvc;

namespace Business.Service
{
    public class EventService : IEventService
    {

        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        [ServiceFilter(typeof(CustomExceptionFilter))]
        public async Task<AddEvent> AddAsync(AddEvent addEvent)
        {
            return await eventRepository.AddAsync(addEvent);
        }

        [ServiceFilter(typeof(CustomExceptionFilter))]
        public async Task<AddEvent> DeleteAsync(Guid id)
        {
            return await eventRepository.DeleteAsync(id);
        }

        [ServiceFilter(typeof(CustomExceptionFilter))]
        public async Task<IEnumerable<AddEvent>> GetAllAsync()
        {
            return await eventRepository.GetAllAsync();
        }

        [ServiceFilter(typeof(CustomExceptionFilter))]
        public async Task<AddEvent> GetAsync(Guid id)
        {
            return await eventRepository.GetAsync(id);
        }

        [ServiceFilter(typeof(CustomExceptionFilter))]
        public async Task<AddEvent> UpdateAsync(AddEvent addEvent)
        {
            return await eventRepository.UpdateAsync(addEvent);
        }


        
    }
}
