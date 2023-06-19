using CommonModel.Model;
using Event.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Factory
{
    public class EventFactory : IEventModelFactory
    {
        public AddEvent CreateAddEvent(AddEventRequest addEventRequest)
        {
            return new AddEvent
            {
                title = addEventRequest.title,
                date = addEventRequest.date,
                location = addEventRequest.location,
                startTime = addEventRequest.startTime,
                Visible = addEventRequest.Visible,
                durationInHours = addEventRequest.durationInHours,
                description = addEventRequest.description,
                otherDetails = addEventRequest.otherDetails,
                InviteByEmail = addEventRequest.InviteByEmail,
                Organiser = addEventRequest.Organiser,
            };
        }

        public AddEvent CreateEditEvent(EditEventViewModel editEventViewModel)
        {
            return new AddEvent
            {
                Id = editEventViewModel.Id,
                title = editEventViewModel.title,
                date = editEventViewModel.date,
                location = editEventViewModel.location,
                startTime = editEventViewModel.startTime,
                Visible = editEventViewModel.Visible,
                durationInHours = editEventViewModel.durationInHours,
                description = editEventViewModel.description,
                otherDetails = editEventViewModel.otherDetails,
                InviteByEmail = editEventViewModel.InviteByEmail,
                Organiser = editEventViewModel.Organiser,
            };
        }

       

      
    }
}
