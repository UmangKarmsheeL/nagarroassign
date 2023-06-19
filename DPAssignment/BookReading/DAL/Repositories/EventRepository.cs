using CommonModel.Model;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly eventDbContext eventDbContext;

        public EventRepository(eventDbContext eventDbContext)
        {
            this.eventDbContext = eventDbContext;
        }
        public async Task<AddEvent> AddAsync(AddEvent addEvent)
        {
            await eventDbContext.AddAsync(addEvent);
            await eventDbContext.SaveChangesAsync();
            return addEvent;
        }

        public async Task<AddEvent> DeleteAsync(Guid id)
        {
            var existingEvent = await eventDbContext.Events.FirstOrDefaultAsync(x => x.Id == id);

            if (existingEvent != null)
            {
                eventDbContext.Events.Remove(existingEvent);
                await eventDbContext.SaveChangesAsync();
                return existingEvent;

            }
            return null;
        }

        public async Task<IEnumerable<AddEvent>> GetAllAsync()
        {
            return (IEnumerable<AddEvent>)await eventDbContext.Events.ToListAsync();
        }

        public async Task<AddEvent> GetAsync(Guid id)
        {
            return await eventDbContext.Events.FirstOrDefaultAsync(x => x.Id == id); 
        }

        public async Task<AddEvent> UpdateAsync(AddEvent addEvent)
        {
           var existingEvent= await eventDbContext.Events.FirstOrDefaultAsync(x => x.Id == addEvent.Id);

            if (existingEvent != null)
            {
                existingEvent.Id = addEvent.Id;
                existingEvent.title = addEvent.title;
                existingEvent.date = addEvent.date;
                existingEvent.location = addEvent.location;
                existingEvent.startTime = addEvent.startTime;
                existingEvent.Visible = addEvent.Visible;
                existingEvent.durationInHours = addEvent.durationInHours;
                existingEvent.description = addEvent.description;
                existingEvent.otherDetails = addEvent.otherDetails;
                existingEvent.InviteByEmail = addEvent.InviteByEmail;
                existingEvent.Organiser = addEvent.Organiser;

                await eventDbContext.SaveChangesAsync();
                return existingEvent;
            }
            return null;
        }
    }
}
