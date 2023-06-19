using BookReadingEvent1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data_Acess_Layer
{
    public interface IEventRepository
    {
        Task<bool> Create([Bind(new[] { "Id,title,date,startTime,location,description,duration,organiser,eventType,invitees" })] EventModel eventModel);
        Task<EventModel> Delete(int? id);
        Task<bool> DeleteConfirmed(int id);
        Task<EventModel> Details(int? id);
        Task<bool> Edit(int id, [Bind(new[] { "Id,title,date,startTime,location,description,duration,organiser,eventType,invitees" })] EventModel eventModel);
        Task<EventModel> Edit(int? id);
        bool EventModelExists(int id);
        Task<List<EventModel>> List();
    }
}