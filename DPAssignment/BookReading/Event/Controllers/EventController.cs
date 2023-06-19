
using Event.Models;
using Event.Models.ViewModels;
using Business.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CommonModel.Model;
using Microsoft.AspNetCore.Identity;
using Event.Factory;
using AutoMapper;
using Business.Facade;

namespace Event.Controllers
{
    public class EventController : Controller
    {

        private readonly ILogger<EventController> _logger;
        public IEventModelFactory eventModelFactory { get; }
        private readonly EventServiceFacadeFactory EventServiceFacadeFactory;

        public EventServiceFacade eventFacade;
        public readonly IMapper mapper;

        public EventController(
        ILogger<EventController> logger,
        IEventModelFactory eventModelFactory,
        IMapper mapper,
        EventServiceFacadeFactory eventServiceFacadeFactory)
        {
            _logger = logger;
            this.mapper = mapper;
            EventServiceFacadeFactory = eventServiceFacadeFactory;
            eventFacade = EventServiceFacadeFactory.CreateEventServiceFacade();
            this.eventModelFactory = eventModelFactory;
        }

        [HttpGet]
        public IActionResult Add()
        {
            _logger.LogInformation("Add action called.");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEventRequest addEventRequest)
        {

            _logger.LogInformation("Add Event Request Received.");
            if (ModelState.IsValid)
            {
                var addEvent = eventModelFactory.CreateAddEvent(addEventRequest);

                await eventFacade.AddAsync(addEvent);

                return RedirectToAction("List");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var Events = await eventFacade.GetAllAsync();

            return View(Events);
        }
        [HttpGet]
        public async Task<IActionResult> MyEvent()
        {
            _logger.LogInformation("My Event Called");
            var Events = await eventFacade.GetAllAsync();

            return View(Events);
        }

        [HttpGet]
        public async Task<IActionResult> EventsInvitedTo()
        {
            _logger.LogInformation("EventsInvitedTo action called.");
            var Events = await eventFacade.GetAllAsync();

            return View(Events);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            _logger.LogInformation("Edit Action Called");
            var addEvent = await eventFacade.GetAsync(id);
            if (addEvent != null)
            {
                var editEvent = mapper.Map<AddEvent, EditEventViewModel>(addEvent);
                return View(editEvent);
            }
            return View(null);
        }

        public async Task<IActionResult> EventView(Guid id)
        {
            var addEvent = await eventFacade.GetAsync(id);
            if (addEvent != null)
            {
                var editEvent = mapper.Map<AddEvent, EditEventViewModel>(addEvent);
                return View(editEvent);
            }
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditEventViewModel editEventViewModel)
        {
            _logger.LogInformation("Edit Request Received");
            var model = eventModelFactory.CreateEditEvent(editEventViewModel);

            var updatedEvent = await eventFacade.UpdateAsync(model);
            if (updatedEvent != null)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("Edit");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EditEventViewModel editEventViewModel)
        {
            var deletedEvent = await eventFacade.DeleteAsync(editEventViewModel.Id);
            if (deletedEvent != null)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("Edit");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [Route("customer-support")]
        public IActionResult CustomerSupport()
        {
            return Redirect("http://helpdesk.nagarro.com");
        }
    }
}



