using BookReadingEvent1.Data;
using BookReadingEvent1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public class EventRepository : IEventRepository
    {
        private EventContext _context;

        public EventRepository(EventContext context)
        {
            _context = context;
        }
        public async Task<List<EventModel>> List()
        {
            return await _context.EventModel.ToListAsync();

        }
        public async Task<EventModel> Details(int? id)
        {

            var eventModel = await _context.EventModel
                .FirstOrDefaultAsync(m => m.Id == id);
            return eventModel;
        }
        public async Task<bool> Create([Bind("Id,title,date,startTime,location,description,duration,organiser,eventType,invitees")] EventModel eventModel)
        {
            _context.Add(eventModel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<EventModel> Edit(int? id)
        {
            var eventModel = await _context.EventModel.FindAsync(id);
            return eventModel;
        }
        public async Task<bool> Edit(int id, [Bind("Id,title,date,startTime,location,description,duration,organiser,eventType,invitees")] EventModel eventModel)
        {
            _context.Update(eventModel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<EventModel> Delete(int? id)
        {
            var eventModel = await _context.EventModel
                .FirstOrDefaultAsync(m => m.Id == id);

            return eventModel;
        }

        public async Task<bool> DeleteConfirmed(int id)
        {
            var eventModel = await _context.EventModel.FindAsync(id);
            _context.EventModel.Remove(eventModel);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool EventModelExists(int id)
        {
            return _context.EventModel.Any(e => e.Id == id);
        }

    }

}
