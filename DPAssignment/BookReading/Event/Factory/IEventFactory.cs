using CommonModel.Model;
using Event.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Factory
{
    public interface IEventModelFactory
    {
        AddEvent CreateAddEvent(AddEventRequest addEventRequest);
        AddEvent CreateEditEvent(EditEventViewModel editEventViewModel);
       
    }
}
