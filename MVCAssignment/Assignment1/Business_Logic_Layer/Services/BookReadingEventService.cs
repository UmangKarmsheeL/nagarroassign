using AutoMapper;
using BookReadingEvent1.Data;
using BookReadingEvent1.DTOs;
using BookReadingEvent1.Models;
using Data_Acess_Layer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public class BookReadingEventService : IBookReadingEventService

    {
        private readonly IEventRepository eventRepository;
        
        public BookReadingEventService(IEventRepository _eventRepository)
        {
            eventRepository = _eventRepository;
        }
        public async Task<List<EventModel>> List()
        {
            return await eventRepository.List();
           
        }
        public async Task<EventModel> Details(int? id)
        {
            var newEvent = await eventRepository.Details(id);
            return newEvent;
        }
        public async Task<bool> Create(EventModel Event)
        {
            return await eventRepository.Create(Event);
        }
        public async Task<EventModel> Edit(int? id)
        {
            var newevent = await eventRepository.Edit(id);
            return newevent;
        }
        public async Task<bool> Edit(int id, EventModel Event)
        {
            return await eventRepository.Edit(id,Event);
        }
        public async Task<EventModel> Delete(int? id)
        {
            var newevent= await eventRepository.Delete(id);
            return newevent; 
        }
        public async Task<bool> DeleteConfirmed(int id)
        {
            return await eventRepository.DeleteConfirmed(id);
          
        }
        public bool EventModelExists(int id)
        {
            return eventRepository.EventModelExists(id);
        }
    }
}
