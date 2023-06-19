using BookReadingEvent1.DTOs;
using BookReadingEvent1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    public interface IBookReadingEventService
    {
        Task<bool> Create(EventModel eventModel);
        Task<EventModel> Delete(int? id);
        Task<bool> DeleteConfirmed(int id);
        Task<EventModel> Details(int? id);
        Task<bool> Edit(int id, EventModel eventModel);
        Task<EventModel> Edit(int? id);
        bool EventModelExists(int id);
        Task<List<EventModel>> List();
    }
}